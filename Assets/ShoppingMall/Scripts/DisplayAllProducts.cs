using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayAllProducts : MonoBehaviour
{
    public List<GameObject> TempGoList;
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
}
