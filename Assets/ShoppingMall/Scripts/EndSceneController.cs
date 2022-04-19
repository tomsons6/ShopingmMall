using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Localization;

public class EndSceneController : MonoBehaviour
{
    [SerializeField]
    Text ResultText;
    [SerializeField]
    Text GetAllProducts;
    // Start is called before the first frame update
    void Awake()
    {
        showResult();
    }
    void Start()
    {
        ResultText.text += GameManager.Instance.CurrentBudget;
    }
    void showResult()
    {
        if(GameManager.Instance.CurrentBudget > 0)
        {
            ResultText.GetComponent<UILocalization>().Key = "WonGame";
            ResultText.text += GameManager.Instance.CurrentBudget.ToString();
        }
        else
        {
            ResultText.GetComponent<UILocalization>().Key = "LostGame";
            
        }
        if (GameManager.Instance.GotAllProducts)
        {
            GetAllProducts.GetComponent<UILocalization>().Key = "GotAllProducts";
        }
        else
        {
            GetAllProducts.GetComponent<UILocalization>().Key = "NotAllProducts";
        }

    }

    public void LoadMainMenu()
    {
        GameManager.Instance.GotAllProducts = false;
        SceneManager.LoadScene("MenuScreen");
    }
}
