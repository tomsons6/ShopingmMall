using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class ClickOnShelf : MonoBehaviour
{
    [SerializeField]
    GameObject Screen1ProductDisplay;
    [SerializeField]
    GameObject Screen1Camera;
    [SerializeField]
    GameObject Screen2ProductDisplay;
    [SerializeField]
    GameObject Screen2Camera;
    [SerializeField]
    DisplayAllProducts DspAllProd;

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
                    Screen1Camera.SetActive(true);
                    Screen1ProductDisplay.SetActive(true);
                    Screen2Camera.SetActive(true);
                    Screen2ProductDisplay.SetActive(true);
                    DspAllProd.DisplayProductCategory(hit.transform.GetComponent<CategoryInfo>().categoryInfo);
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (Screen1Camera.activeInHierarchy && Screen1ProductDisplay.activeInHierarchy && Screen2Camera.activeInHierarchy && Screen2ProductDisplay.activeInHierarchy)
            {
                //Screen1Camera.SetActive(false);
                //Screen2Camera.SetActive(false);
                DspAllProd.ResetDisplay();
                foreach (GameObject go in DspAllProd.TempGoList)
                {
                    Destroy(go);
                }
                Screen1ProductDisplay.SetActive(false);
                Screen2ProductDisplay.SetActive(false);
                DspAllProd.TempGoList.Clear();
            }
        }
    }
}
