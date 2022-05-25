using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Localization;

public class LocalizationToggle : MonoBehaviour
{
    [SerializeField]
    Toggle LvToggle;
    [SerializeField]
    Toggle RusToggle;
    [SerializeField]
    Toggle EngToggle;

    MainMenuController MainMenuController;
    // Start is called before the first frame update
    void Start()
    {
        LvToggle.onValueChanged.AddListener(onSetLatvian);
        RusToggle.onValueChanged.AddListener(onSetRussian);
        EngToggle.onValueChanged.AddListener(onSetEnglish);

        //CheckLocalization();
        MainMenuController = GetComponent<MainMenuController>();
    }

    private void CheckLocalization()
    {
        if (LocalizationService.Instance == null) return;

        switch (LocalizationService.Instance.Localization)
        {
            case "Russian":
                RusToggle.isOn = true;
                break;
            case "English":
                EngToggle.isOn = true;
                break;
            case "Latvian":
                LvToggle.isOn = true;
                break;
        }
    }
    void onSetLatvian(bool enable)
    {
        if (!enable) return;
        LocalizationService.Instance.Localization = "Latvian";
        Debug.Log(LocalizationService.Instance.Localization);
        MainMenuController.ShoppingListLanguageChange();
    }
    void onSetRussian(bool enable)
    {
        if (!enable) return;
        LocalizationService.Instance.Localization = "Russian";
        Debug.Log(LocalizationService.Instance.Localization);
        MainMenuController.ShoppingListLanguageChange();
    }
    void onSetEnglish(bool enable)
    {
        if (!enable) return;
        LocalizationService.Instance.Localization = "English";
        Debug.Log(LocalizationService.Instance.Localization);
        MainMenuController.ShoppingListLanguageChange();
    }

}
