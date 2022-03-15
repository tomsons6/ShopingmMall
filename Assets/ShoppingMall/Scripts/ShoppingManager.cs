using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShoppingManager : MonoBehaviour
{
    ShoppingList ShList;
    double Budget;
    ShoppingListDisplay ShLDisp;
    [SerializeField]
    public List<CheckIfItemBought> ShoppingListCheck;
    // Start is called before the first frame update
    void Start()
    {
        ShList = GameManager.Instance.SelectedShoppingList;
        ShLDisp = GameObject.FindGameObjectWithTag("ShopListDisp").GetComponent<ShoppingListDisplay>();
        foreach (Product.Category cat in ShList.ShoppingListProducts)
        {
            ShoppingListCheck.Add(new CheckIfItemBought(cat, false,null));
        }
        Budget = ShList.Budget;
        ShLDisp.GetComponentInChildren<Text>().text = "Budget = " + Budget;
    }
    public void checkForBoughtProducts(Product prod)
    {
        foreach (CheckIfItemBought check in ShoppingListCheck)
        {
            if (check.ProductCat == prod.ProductCategory && !check.IsBought)
            {
                foreach (GameObject Go in ShLDisp.SPListButtons)
                {
                    ShoppingCartItem TempCartItem = Go.GetComponent<ShoppingCartItem>();
                    if (TempCartItem.CartItem == null && TempCartItem.CategoryInfo == prod.ProductCategory )
                    {
                        ButtonColorChange(Color.green, Go.GetComponent<Button>());
                        check.TakenProduct = prod;
                        TempCartItem.CartItem = prod;                       
                        //decrease budget
                        DecreaseBudget(prod);
                        check.IsBought = true;
                        break;
                    }
                }
                break;
            }
        }
    }
    public void ButtonColorChange(Color color, Button button)
    {
        var Colors = button.colors;
        Colors.selectedColor = color;
        Colors.normalColor = color;
        Colors.pressedColor = color;
        button.colors = Colors;
    }
    public void DecreaseBudget(Product prod)
    {
        Budget -= prod.price;
        ShLDisp.GetComponentInChildren<Text>().text = "Budget = " + Budget;
    }
    public void IncreaseBudget(Product prod)
    {
        Budget += prod.price;
        ShLDisp.GetComponentInChildren<Text>().text = "Budget = " + Budget;
    }

    public void CheckOutPressed()
    {
        GameManager.Instance.CurrentBudget = Budget;
        SceneManager.LoadScene("EndScene");
    }
}
[System.Serializable]
public class CheckIfItemBought
{
    public Product.Category ProductCat;
    public bool IsBought;
    public Product TakenProduct;
    public CheckIfItemBought(Product.Category ProdCat, bool Bought, Product TakeProd)
    {
        this.ProductCat = ProdCat;
        this.IsBought = Bought;
        this.TakenProduct = TakeProd;
    }
}
