using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public enum MenuId { ClickToStart = 1, ChoseAge = 2, Age7 = 3, Age10 = 4, Age15 = 5, Instructions = 6, ShoppingList = 7 };
    [SerializeField]
    List<PanelId> PanelObjects;

    [SerializeField]
    int BackButtonID;
    [SerializeField]
    Text ShoppingListField;
    [SerializeField]
    Text Budget;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.CurrentBudget = 0;
        foreach(Transform child in transform)
        {
            if(child.GetComponent<PanelId>() != null)
            {
                PanelObjects.Add(child.GetComponent<PanelId>());
            }
        }
        foreach(PanelId Panel in PanelObjects)
        {
            if (Panel.ID == MenuId.ClickToStart)
            {
                Panel.gameObject.SetActive(true);
            }
            else
            {
                Panel.gameObject.SetActive(false);
            }
        }

    }

    public void setActivePanel(int ID)
    {
        foreach(PanelId Panel in PanelObjects)
        {
            if (Panel.ID == (MenuId)ID)
            {
                Panel.gameObject.SetActive(true);
                if(Panel.ID == MenuId.Age10 || Panel.ID == MenuId.Age15 || Panel.ID == MenuId.Age7)
                {
                    BackButtonID = (int)Panel.ID;
                }
            }
            else
            {
                Panel.gameObject.SetActive(false);
            }
        }
        if (ID == 7)
        {
            int numb = 0;
            if (GameManager.Instance.SelectedShoppingList != null)
            {
                foreach (Product.Category prod in GameManager.Instance.SelectedShoppingList.ShoppingListProducts)
                {
                    numb++;
                    ShoppingListField.text += "\n" + numb + ". " + prod.ToString();
                }
            }
            Budget.text = "Budget = " + GameManager.Instance.SelectedShoppingList.Budget;
        }
        else
        {
            ShoppingListField.text = "";
        }

    }

    public void BackToSpecificPanel()
    {
        foreach (PanelId Panel in PanelObjects)
        {
            if (Panel.ID == (MenuId)BackButtonID)
            {
                Panel.gameObject.SetActive(true);
            }
            else
            {
                Panel.gameObject.SetActive(false);
            }
        }
    }
    public void SelectShoppingList(ShoppingList List)
    {
        GameManager.Instance.SelectedShoppingList = List;
    }
    public void LoadShopScene()
    {
        SceneManager.LoadScene("ShopScene");
        
    }
}
