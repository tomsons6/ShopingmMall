using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayAllProducts : MonoBehaviour
{
    public List<GameObject> TempGoList;

    ShoppingManager SPManager;

    void Start()
    {
        SPManager = GameObject.FindGameObjectWithTag("ShopManager").GetComponent<ShoppingManager>();
    }

    public void DisplayProductCategory(Product.Category category)
    {
        Debug.Log("Display category");
        foreach (Product prod in ProductManager.Instance.AllProducts)
        {
            Debug.Log(prod.Name);
            if (prod.ProductCategory == category)
            {
                foreach (ProductDisplay disp in this.gameObject.GetComponentsInChildren(typeof(ProductDisplay)))
                {
                    if (!disp.isDisplayed)
                    {
                        disp.ShowProductInfo(prod);
                        disp.BuyButton.onClick.AddListener(delegate { Buy(prod); });
                        TempGoList.Add(disp.TempGo);
                        disp.isDisplayed = true;
                        break;
                    }
                }
            }
        }
    }
    public void ResetDisplay()
    {
        foreach(ProductDisplay disp in this.gameObject.GetComponentsInChildren(typeof(ProductDisplay)))
        {
            disp.isDisplayed = false;
        }
    }
    public void Buy(Product product)
    {
        SPManager.checkForBoughtProducts(product);
    }
}
