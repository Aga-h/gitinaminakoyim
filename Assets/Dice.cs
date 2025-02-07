using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Dice : MonoBehaviour
{
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int dice = Random.Range(1, 7);
        int anim;
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log(dice);
            if (dice == 1)
            {
                anim = 1;
            }
            else if (dice == 2) { anim = 2; }
            else if (dice == 3) { anim = 3; }
            else if (dice == 4) { anim = 4; }
            else if (dice == 5) { anim = 5; }
            else if (dice == 6) { anim = 6; }
        }
    }
}
