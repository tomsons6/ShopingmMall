using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewShoppingList", menuName = "ShoppingList")]
public class ShoppingList : ScriptableObject
{
    public double Budget;
    public List<Product.Category> ShoppingListProducts;
}
