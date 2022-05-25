using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
    [SerializeField]
    GameObject ProductPanel1;
    [SerializeField]
    GameObject EmptyPanel1;
    [SerializeField]
    GameObject ProductPanel2;
    [SerializeField]
    GameObject EmptyPanel2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Camera.main.pixelRect.Contains(Input.mousePosition))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(Input.mousePosition, Vector3.forward, color: Color.green);
            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                if (hit.transform.tag == "Shelf")
                {
                    ResetDisplay();
                    EmptyPanel1.SetActive(false);
                    ProductPanel1.SetActive(true);
                    EmptyPanel2.SetActive(false);
                    ProductPanel2.SetActive(true);
                    //Screen1Camera.SetActive(true);
                    //Screen1ProductDisplay.SetActive(true);
                    //Screen2Camera.SetActive(true);
                    //Screen2ProductDisplay.SetActive(true);
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
                ResetDisplay();
            }
        }
        if (Input.touchCount > 0 && Camera.main.pixelRect.Contains(Input.GetTouch(0).rawPosition))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).rawPosition);
            Debug.DrawRay(Input.mousePosition, Vector3.forward, color: Color.green);
            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                if (hit.transform.tag == "Shelf")
                {
                    ResetDisplay();
                    EmptyPanel1.SetActive(false);
                    ProductPanel1.SetActive(true);
                    EmptyPanel2.SetActive(false);
                    ProductPanel2.SetActive(true);
                    //Screen1Camera.SetActive(true);
                    //Screen1ProductDisplay.SetActive(true);
                    //Screen2Camera.SetActive(true);
                    //Screen2ProductDisplay.SetActive(true);
                    DspAllProd.DisplayProductCategory(hit.transform.GetComponent<CategoryInfo>().categoryInfo);
                }
            }
        }
    }
    void ResetDisplay()
    {
        DspAllProd.ResetDisplay();
        foreach (GameObject go in DspAllProd.TempGoList)
        {
            Destroy(go);
        }
        //Screen1ProductDisplay.SetActive(false);
        //Screen2ProductDisplay.SetActive(false);
        DspAllProd.TempGoList.Clear();
        EmptyPanel1.SetActive(true);
        ProductPanel1.SetActive(false);
        EmptyPanel2.SetActive(true);
        ProductPanel2.SetActive(false);
    }
}
