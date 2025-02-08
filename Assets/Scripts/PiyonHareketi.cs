using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiyonHareketi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2((Dice.finalSide1 + Dice2.finalSide2) * 1.5f, 0f);
    }
}
