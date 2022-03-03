using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ProductManager : MonoBehaviour
{
    public List<Product> AllProducts;

    public static ProductManager Instance;
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
