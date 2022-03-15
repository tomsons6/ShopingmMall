using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayAllProducts : MonoBehaviour
{
    public List<GameObject> TempGoList;

    ShoppingManager SPManager;

    [SerializeField]
    GameObject ProdDisp1;
    [SerializeField]
    GameObject ProdDisp2;

    public List<DisplayProducts> DispProductCheck;

    void Start()
    {
        SPManager = GetComponent<ShoppingManager>();
        foreach(Product prod in ProductManager.Instance.AllProducts)
        {
            DispProductCheck.Add(new DisplayProducts(prod, false));
        }
    }

    public void DisplayProductCategory(Product.Category category)
    {
        Debug.Log("Display category");
        foreach (DisplayProducts prod in DispProductCheck)
        {
            if (prod.Prod.ProductCategory == category)
            {
                foreach (ProductDisplay disp in ProdDisp1.GetComponentsInChildren(typeof(ProductDisplay)))
                {
                    if (!disp.isDisplayed && !prod.IsDisplayed)
                    {
                        prod.IsDisplayed = true;
                        disp.ShowProductInfo(prod.Prod);
                        disp.BuyButton.onClick.AddListener(delegate { Buy(prod.Prod); });
                        TempGoList.Add(disp.TempGo);
                        disp.isDisplayed = true;
                        break;
                    }
                }
                foreach (ProductDisplay disp in ProdDisp2.GetComponentsInChildren(typeof(ProductDisplay)))
                {
                    if (!disp.isDisplayed && !prod.IsDisplayed)
                    {
                        prod.IsDisplayed = true;
                        disp.ShowProductInfo(prod.Prod);
                        disp.BuyButton.onClick.AddListener(delegate { Buy(prod.Prod); });
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
        foreach(ProductDisplay disp in ProdDisp1.GetComponentsInChildren(typeof(ProductDisplay)))
        {
            disp.isDisplayed = false;
            disp.BuyButton.onClick.RemoveAllListeners();
        }
        foreach (ProductDisplay disp in ProdDisp2.GetComponentsInChildren(typeof(ProductDisplay)))
        {
            disp.isDisplayed = false;
            disp.BuyButton.onClick.RemoveAllListeners();
        }
        foreach(DisplayProducts prod in DispProductCheck)
        {
            prod.IsDisplayed = false;
        }
    }
    public void Buy(Product product)
    {
        SPManager.checkForBoughtProducts(product);
    }
}
[System.Serializable]
public class DisplayProducts
{
    public Product Prod;
    public bool IsDisplayed;
    public DisplayProducts(Product cat, bool isDisp)
    {
        this.Prod = cat;
        this.IsDisplayed = isDisp;
    }
}
