using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneController : MonoBehaviour
{
    [SerializeField]
    Text ResultText;
    // Start is called before the first frame update
    void Start()
    {
        showResult();
    }
    
    void showResult()
    {
        if(GameManager.Instance.CurrentBudget > 0)
        {
            ResultText.text = "Congratulations you are within the budget. Your left over budget is = " + GameManager.Instance.CurrentBudget;
        }
        else
        {
            ResultText.text = "Unfortunatly you over spent your budget. You overdrafted = " + GameManager.Instance.CurrentBudget;
        }
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MenuScreen");
    }
}
