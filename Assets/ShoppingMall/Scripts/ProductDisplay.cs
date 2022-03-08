using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductDisplay : MonoBehaviour
{
    //public Product product;

    [SerializeField]
    Text ProductName;
    [SerializeField]
    GameObject ProductModel;
    [SerializeField]
    Text ProductDesctription;
    [SerializeField]
    Text ProductPrice;
    [SerializeField]
    public Button BuyButton;
    
    public bool isDisplayed;

    public GameObject TempGo;
    public void ShowProductInfo(Product product)
    {
        ProductName.text = product.Name;
        TempGo = Instantiate(product.Model);
        TempGo.transform.parent = ProductModel.transform;
        TempGo.transform.localPosition = new Vector3(0f, -100f, 0f);
        TempGo.transform.localScale = new Vector3(500f, 500f, 500f);
        ProductDesctription.text = product.Desctription;
        ProductPrice.text = "Price = " + product.price.ToString();
    }
}
