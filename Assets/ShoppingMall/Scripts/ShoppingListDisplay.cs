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
        ProdList = GameManager.Instance.SelectedShoppingList;
        foreach (Product.Category cat in ProdList.ShoppingListProducts)
        {
            GameObject TempObj = Instantiate(CategoryDisplay, CategoryRoot.transform);
            TempObj.GetComponent<CategoryInfo>().categoryInfo = cat;
            SPListButtons.Add(TempObj);
            TempObj.GetComponentInChildren<Text>().text = cat.ToString();

        }
    }
}

