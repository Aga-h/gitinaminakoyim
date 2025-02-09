using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyableProperties : MonoBehaviour
{

    public new string name;
    public int value;
    public int PricePerHouse;
    public int Rent1;
    public int Rent2;
    public int Rent3;
    public int Rent4;
    public int Rent5;
    public int Mortgage;

    public BuyableProperties(string newName, int newValue) 
    {
        name = newName;
        value = newValue;
        PricePerHouse = newValue;
        Rent1 = newValue;
        Rent2 = newValue;
        Rent3 = newValue;
        Rent4 = newValue;
        Rent5 = newValue;
        Mortgage = newValue;

    }
}
