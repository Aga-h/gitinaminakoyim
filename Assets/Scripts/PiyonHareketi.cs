using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiyonHareketi : MonoBehaviour
{
    int ToGo;
    Transform trans;
    void Start()
    {
        ToGo = Dice.finalSide1 + Dice2.finalSide2;
        transform.position = new Vector2(15, -15);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
