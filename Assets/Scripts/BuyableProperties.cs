using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyableProperties : MonoBehaviour
{

    public static new string name;
    public static int Price;
    public static int PricePerHouse;
    public static int Rent1;
    public static int Rent2;
    public static int Rent3;
    public static int Rent4;
    public static int Rent5;
    public static int Rent6;
    public static int Mortgage;

    public BuyableProperties(string newName, int newValue, int newValue1, int newValue2, int newValue3, int newValue4, int newValue5, int newValue6, int newValue7, int newValue8) 
    {
        name = newName;
        Price = newValue;
        PricePerHouse = newValue1;
        Rent1 = newValue2;
        Rent2 = newValue3;
        Rent3 = newValue4;
        Rent4 = newValue5;
        Rent5 = newValue6;
        Rent6 = newValue7;
        Mortgage = newValue8;

    }
}
