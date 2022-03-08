using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ShoppingList SelectedShoppingList;

    public static GameManager Instance;
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
}

