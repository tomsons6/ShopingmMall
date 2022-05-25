using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Localization;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "New Product", menuName = "Products")]
public class Product : ScriptableObject
{
    public string NameEng;
    public string NameLv;
    public string NameRus;

    public string DesctriptionEng;
    public string DesctriptionRus;
    public string DesctriptionLV;

    public GameObject Model;


    public enum Category { Milk, Bread, planks, nails, Oil, Onion, Garlic, Carrot, minced_meat, Tomato_paste, Canned_tomatoes, Oregano, Timian, Salt, Pepper, Spagheti, Chesse, Washing_Powder, ToiletPaper, Paper_Towels, ToothPaste, Sushi_rice, rice_vinegar, water, Salmon, shrimp, crab_sticks, avocado, cucumber, creamchese, caviear, seaweed_pages, soy_sauce, pickled_ginger, vasabi, cleaning_cloth, broom, toilet_cleaner, bathroom_cleaner, kitchen_cleaner, window_cleaner, Dishsoap, sponge, cottage_cheese, wheat_flour, eggs, powdered_sugar, baking_powder, honey, hammer};

    public Category ProductCategory;

    public double price;

    public Sprite ProductCategoryImage;

    public double quantity;
    public string quantityUnit;

    public string NameTranslate()
    {
        string TranslatedName = null;
        if (LocalizationService.Instance.Localization == "English")
        {
            TranslatedName = NameEng;
        }
        if (LocalizationService.Instance.Localization == "Russian")
        {
            TranslatedName = NameRus;
        }
        if (LocalizationService.Instance.Localization == "Latvian")
        {
            TranslatedName = NameLv;
        }
        return TranslatedName;
    }
    public string DescriptionTranslate()
    {
        string TranslateDescription = null;
        if (LocalizationService.Instance.Localization == "English")
        {
            TranslateDescription = DesctriptionEng;
        }
        if (LocalizationService.Instance.Localization == "Russian")
        {
            TranslateDescription = DesctriptionRus;
        }
        if (LocalizationService.Instance.Localization == "Latvian")
        {
            TranslateDescription = DesctriptionLV;
        }
        return TranslateDescription;
    }
}
