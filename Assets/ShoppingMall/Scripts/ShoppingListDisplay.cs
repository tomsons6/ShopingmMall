using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShoppingListDisplay : MonoBehaviour
{
    [SerializeField]
    ShoppingList ProdList;

    public GameObject CategoryDisplay;
    public GameObject CategoryRoot;

    public List<GameObject> SPListButtons;
    // Start is called before the first frame update
    void Start()
    {
        if (!GameManager.Instance.FreeRoam)
        {
            ProdList = GameManager.Instance.SelectedShoppingList;
            foreach (Product.Category cat in ProdList.ShoppingListProducts)
            {
                GameObject TempObj = Instantiate(CategoryDisplay, CategoryRoot.transform);
                TempObj.GetComponent<ShoppingCartItem>().CategoryInfo = cat;
                SPListButtons.Add(TempObj);
                TempObj.GetComponentInChildren<Text>().text = cat.ToString();

            }
        }
    }
    public void FreeRoamShopListDisp(Product prod)
    {
        GameObject TempGo = Instantiate(CategoryDisplay, CategoryRoot.transform);
        TempGo.GetComponent<ShoppingCartItem>().CategoryInfo = prod.ProductCategory;
        TempGo.GetComponent<ShoppingCartItem>().CartItem = prod;
        SPListButtons.Add(TempGo);
        TempGo.GetComponentInChildren<Text>().text = prod.ProductCategory.ToString();
    }
}

