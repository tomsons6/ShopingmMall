using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class ShoppingManager : MonoBehaviour
{
    ShoppingList ShList;
    double Budget;
    ShoppingListDisplay ShLDisp;
    [SerializeField]
    public List<CheckIfItemBought> ShoppingListCheck;

    public Sprite GreenTick;
    public Sprite RedCross;
    // Start is called before the first frame update
    void Start()
    {
        ShList = GameManager.Instance.SelectedShoppingList;
        ShLDisp = GameObject.FindGameObjectWithTag("ShopListDisp").GetComponent<ShoppingListDisplay>();
        foreach (ShoppingListItem cat in ShList.ShoppingListProducts)
        {
            ShoppingListCheck.Add(new CheckIfItemBought(cat.ShoppingListProduct, false, null));
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
                    if (TempCartItem.CartItem == null && TempCartItem.CategoryInfo == prod.ProductCategory)
                    {
                        //ButtonColorChange(Color.green, Go.GetComponent<Button>());
                        changeSprite(Go.GetComponentsInChildren<Image>()[1], GreenTick);
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

    public void BuyFreeRoam(Product prod)
    {
        ShLDisp.FreeRoamShopListDisp(prod);
        DecreaseBudget(prod);
    }
    //public void ButtonColorChange(Color color, Button button)
    //{
    //    var Colors = button.colors;
    //    Colors.selectedColor = color;
    //    Colors.normalColor = color;
    //    Colors.pressedColor = color;
    //    button.colors = Colors;
    //}
    public void changeSprite(Image buttonImage, Sprite tick)
    {
        buttonImage.sprite = tick;
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
        if (!GameManager.Instance.FreeRoam)
        {
            if (ShoppingListCheck.All(x => x.IsBought == true))
            {
                GameManager.Instance.GotAllProducts = true;
            }
            else
            {
                GameManager.Instance.GotAllProducts = false;
            }
        }
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
