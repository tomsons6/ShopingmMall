using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class ClickOnShelf : MonoBehaviour
{
    [SerializeField]
    GameObject ShoppingListDisplay;
    [SerializeField]
    GameObject CanvasCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(Input.mousePosition, Vector3.forward, color: Color.green);
            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                if (hit.transform.tag == "Shelf")
                {
                    hit.transform.GetComponent<NetworkShelf>().ClickOnShelf();
                    CanvasCamera.SetActive(true);
                    ShoppingListDisplay.SetActive(true);
                    ShoppingListDisplay.GetComponent<DisplayAllProducts>().DisplayProductCategory(hit.transform.GetComponent<ShelfInfo>().ShelfProducts);
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (CanvasCamera.activeInHierarchy && ShoppingListDisplay.activeInHierarchy)
            {
                CanvasCamera.SetActive(false);
                ShoppingListDisplay.GetComponent<DisplayAllProducts>().ResetDisplay();
                foreach (GameObject go in ShoppingListDisplay.GetComponent<DisplayAllProducts>().TempGoList)
                {
                    Destroy(go);
                }
                ShoppingListDisplay.GetComponent<DisplayAllProducts>().TempGoList.Clear();
                ShoppingListDisplay.SetActive(false);
            }
        }
    }
}
