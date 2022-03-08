using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Product", menuName = "Products")]
public class Product : ScriptableObject
{
    public string Name;
    public string Desctription;

    public GameObject Model;

    public enum Category {Milk, Bread, wood, vegetables, nails, CanFood};

    public Category ProductCategory;

    public double price;
}
