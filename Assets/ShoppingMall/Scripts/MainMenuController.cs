using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;

public class MainMenuController : MonoBehaviour
{
    public enum MenuId { ClickToStart = 1, ChoseAge = 2, Age7 = 3, Age10 = 4, Age15 = 5, Instructions = 6, ShoppingList = 7 };
    [SerializeField]
    List<PanelId> PanelObjects;

    [SerializeField]
    int BackButtonID;
    // Start is called before the first frame update
    void Start()
    {
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
