using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ShoppingCartItem : MonoBehaviour
{
    public Product CartItem;
    public Product.Category CategoryInfo;
    ShoppingManager ShManager;

    void Start()
    {
        ShManager = GameObject.FindGameObjectWithTag("ShopManager").GetComponent<ShoppingManager>();
        this.gameObject.GetComponent<Button>().onClick.AddListener(RemoveItem);
    }

    public void RemoveItem()
    {
        if (!GameManager.Instance.FreeRoam)
        {
            CheckIfItemBought TempCartItem = ShManager.ShoppingListCheck.Find(x => x.TakenProduct == CartItem);
            ShManager.IncreaseBudget(CartItem);
            //ShManager.ButtonColorChange(Color.red, GetComponent<Button>());
            ShManager.changeSprite(GetComponentsInChildren<Image>()[1], ShManager.RedCross);
            TempCartItem.IsBought = false;
            TempCartItem.TakenProduct = null;
            CartItem = null;
        }
        else
        {
            ShManager.IncreaseBudget(CartItem);
            Destroy(this.gameObject);
        }


    }
}
