using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            ShoppingListCheck.Add(new CheckIfItemBought(cat, false));
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
                    var Colors = Go.GetComponent<Button>().colors;
                    if (Colors.normalColor != Color.green && Go.GetComponent<CategoryInfo>().categoryInfo == prod.ProductCategory)
                    {
                        
                        Colors.selectedColor = Color.green;
                        Colors.normalColor = Color.green;
                        Colors.pressedColor = Color.green;
                        Go.GetComponent<Button>().colors = Colors;
                        //decrease budget
                        DecreaseBudget(prod);
                        break;
                    }
                }
                check.IsBought = true;
                break;
            }
        }
    }
    public void DecreaseBudget(Product prod)
    {
        Budget -= prod.price;
        ShLDisp.GetComponentInChildren<Text>().text = "Budget = " + Budget;
    }
}
[System.Serializable]
public class CheckIfItemBought
{
    public Product.Category ProductCat;
    public bool IsBought;
    public CheckIfItemBought(Product.Category ProdCat, bool Bought)
    {
        this.ProductCat = ProdCat;
        this.IsBought = Bought;
    }
}
