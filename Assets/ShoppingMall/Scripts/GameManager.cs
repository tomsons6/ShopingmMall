using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ShoppingList SelectedShoppingList;

    public static GameManager Instance;

    public double CurrentBudget;
    public bool GotAllProducts;
    bool CourutineStarted;
    public bool FreeRoam;
    void Awake()
    {
        if (Instance == null)
        {

            Instance = this;
            DontDestroyOnLoad(this.gameObject);

            //Rest of your Awake code

        }
        else
        {
            Destroy(this);
        }

    }
    void Update()
    {
        //if (Input.GetMouseButton(0))
        //{
        //    StopCoroutine(ResetTimer());
        //    CourutineStarted = false;
        //}
        //else
        //{
        //    if(!CourutineStarted )
        //    StartCoroutine(ResetTimer());
        //}
    }

    IEnumerator ResetTimer()
    {
        CourutineStarted = true;
        yield return new WaitForSeconds(10);
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene(0);
            SelectedShoppingList = null;
            CurrentBudget = 0;
            GotAllProducts = false;
        }
        else
        {
            SceneManager.LoadScene(0);
            SelectedShoppingList = null;
            CurrentBudget = 0;
            GotAllProducts = false;
        }
    }
}

