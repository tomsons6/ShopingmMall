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
    public ShoppingManager ShManager;
    // Start is called before the first frame update
    void Start()
    {
        ShManager = GameObject.FindGameObjectWithTag("ShopManager").GetComponent<ShoppingManager>();
        if (!GameManager.Instance.FreeRoam)
        {
            ProdList = GameManager.Instance.SelectedShoppingList;
            foreach (ShoppingListItem cat in ProdList.ShoppingListProducts)
            {
                GameObject TempObj = Instantiate(CategoryDisplay, CategoryRoot.transform);
                TempObj.GetComponent<ShoppingCartItem>().CategoryInfo = cat.ShoppingListProduct;
                SPListButtons.Add(TempObj);
                TempObj.GetComponentsInChildren<Image>()[1].sprite = ShManager.RedCross;
                TempObj.GetComponent<Image>().sprite = cat.ListItemImage;

                TempObj.GetComponentInChildren<Text>().text = cat.localLanguage(cat.ShoppingListProduct);

            }
        }
    }
    public void FreeRoamShopListDisp(Product prod)
    {
        GameObject TempGo = Instantiate(CategoryDisplay, CategoryRoot.transform);
        TempGo.GetComponent<ShoppingCartItem>().CategoryInfo = prod.ProductCategory;
        TempGo.GetComponent<ShoppingCartItem>().CartItem = prod;
        TempGo.GetComponentInChildren<Image>().sprite = prod.ProductCategoryImage;
        SPListButtons.Add(TempGo);
        TempGo.GetComponentInChildren<Text>().text = prod.ProductCategory.ToString();
    }
}

