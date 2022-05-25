using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Localization;

[CreateAssetMenu(fileName = "NewShoppingList", menuName = "ShoppingList")]
public class ShoppingList : ScriptableObject
{
    public double Budget;
    public List<ShoppingListItem> ShoppingListProducts;
}
[System.Serializable]
public class ShoppingListItem
{
    public Product.Category ShoppingListProduct;
    public Sprite ListItemImage;
    public double Quantity;
    public string QuantityUnit;

    public string localLanguage(Product.Category cat)
    {
        string catValue = null;
        switch (cat)
        {
            case Product.Category.Bread:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Bread";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Хлеб";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Maize";
                }
                break;
            case Product.Category.Milk:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Milk";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Молоко";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Piens";
                }
                break;
            case Product.Category.nails:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Nails";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Гвозди";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Naglas";
                }
                break;
            case Product.Category.planks:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Planks";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Доски";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Dēļi";
                }
                break;
            case Product.Category.avocado:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Avocado";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Авокадо";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Avokado";
                }
                break;
            case Product.Category.baking_powder:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Baking powder";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Порошок для выпечки";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Cepamais pūlveris";
                }
                break;
            case Product.Category.bathroom_cleaner:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Bathroom cleaner";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Чистящее средство для ванной";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Vannasistabas tīrīšanas līdzeklis";
                }
                break;
            case Product.Category.broom:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Broom";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Метла";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Slota";
                }
                break;
            case Product.Category.Canned_tomatoes:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Canned tomatoes chopped";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Консервированные помидоры, нарезанные";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Konservēti tomāti sasmalcināti";
                }
                break;
            case Product.Category.Carrot:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Carrot";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Морковь";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Burkāni";
                }
                break;
            case Product.Category.caviear:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Caviear";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Икра";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Ikri";
                }
                break;
            case Product.Category.Chesse:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Cheese";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Сыр";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Siers";
                }
                break;
            case Product.Category.cleaning_cloth:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Cleaning cloth";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Ткань для чистки";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Putekļu lupata";
                }
                break;
            case Product.Category.cottage_cheese:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Cottage cheese";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Творог";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Biezpiens";
                }
                break;
            case Product.Category.crab_sticks:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Crab sticks";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Крабовые палочки";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Krabju nūjiņas";
                }
                break;
            case Product.Category.creamchese:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Cream cheese";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Сливочный сыр";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Krēmsiers";
                }
                break;
            case Product.Category.cucumber:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Cucumber";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Огурец";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Gurķis";
                }
                break;
            case Product.Category.Dishsoap:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Dish soap";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Средство для мытья посуды";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Trauku mazgāšanas līdzeklis ";
                }
                break;
            case Product.Category.eggs:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Eggs";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "яйца";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Olas";
                }
                break;
            case Product.Category.Garlic:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Garlic";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Чеснок";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Ķiploki";
                }
                break;
            case Product.Category.hammer:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Hammer";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Молоток";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Āmurs";
                }
                break;
            case Product.Category.honey:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Honey";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "мед";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Medus";
                }
                break;
            case Product.Category.kitchen_cleaner:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Kitcher cleaner";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Уборщик кухни";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Virtuves tīrīšanas līdzeklis ";
                }
                break;
            case Product.Category.minced_meat:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Beef minced meat";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Говяжий фарш";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Liellopa maltā gaļa ";
                }
                break;
            case Product.Category.Oil:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Cooking oil";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Масло";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Eļļa";
                }
                break;
            case Product.Category.Onion:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Onion";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Лук";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Sīpoli";
                }
                break;
            case Product.Category.Oregano:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Oregano";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "орегано";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Oregāno";
                }
                break;
            case Product.Category.Paper_Towels:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Paper towels";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Бумажные полотенца";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Papīra dvieļi";
                }
                break;
            case Product.Category.Pepper:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Pepper";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Перец";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Pipari";
                }
                break;
            case Product.Category.pickled_ginger:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Pickled ginger";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Маринованный имбирь";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Marinēts ingvers";
                }
                break;
            case Product.Category.powdered_sugar:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Powedered sugar";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Сахарная пудра";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Pūdercukurs";
                }
                break;
            case Product.Category.rice_vinegar:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Rice vinegar";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Рисовый уксус";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Rīsu etiķis";
                }
                break;
            case Product.Category.Salmon:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Salmon";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Лосось";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Lasis";
                }
                break;
            case Product.Category.Salt:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Salt";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Соль";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Sāls";
                }
                break;
            case Product.Category.seaweed_pages:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Seaweed pages";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Страницы морских водорослей";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Nori jūraszāļu lapas";
                }
                break;
            case Product.Category.shrimp:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Shrimp";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Креветка";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Garneles";
                }
                break;
            case Product.Category.soy_sauce:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Soy sauce";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Соевый соус";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Sojas mērce";
                }
                break;
            case Product.Category.Spagheti:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Spaghetti";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Спагетти";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Spageti";
                }
                break;
            case Product.Category.sponge:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Sponge";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Губка";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Švamme";
                }
                break;
            case Product.Category.Sushi_rice:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Sushi rice";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "рис для суши";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Suši rīsi";
                }
                break;
            case Product.Category.Timian:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Thyme";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Тимьян";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Timiāns";
                }
                break;
            case Product.Category.ToiletPaper:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Toilet paper";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Туалетная бумага";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Tualetes papīrs";
                }
                break;
            case Product.Category.toilet_cleaner:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Toilet cleaner";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Средства для чистки туалетов";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Tualetes poda tīrīšanas līdzeklis";
                }
                break;
            case Product.Category.Tomato_paste:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Tomate paste";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "томатная паста";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Tomātu pasta";
                }
                break;
            case Product.Category.ToothPaste:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Toothpaste";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Зубная паста";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Zobu pasta";
                }
                break;
            case Product.Category.vasabi:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Vasabi";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Васаби";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Vasabi";
                }
                break;
            case Product.Category.Washing_Powder:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Washing powder";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Стиральный порошок";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Veļas pūlveris";
                }
                break;
            case Product.Category.water:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Water";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Вода";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Ūdens";
                }
                break;
            case Product.Category.wheat_flour:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Wheat foulr";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Пшеничная мука";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Kviešu milti";
                }
                break;
            case Product.Category.window_cleaner:
                if (LocalizationService.Instance.Localization == "English")
                {
                    catValue = "Window cleaner";
                }
                if (LocalizationService.Instance.Localization == "Russian")
                {
                    catValue = "Стеклоочиститель";
                }
                if (LocalizationService.Instance.Localization == "Latvian")
                {
                    catValue = "Logu tīrīšanas līdzeklis";
                }
                break;
        }
        return catValue;
    }
}
