﻿using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

    static public int randomDiceSide1;
    public static int finalSide1;

    // Array of dice sides sprites to load from Resources folder
    private Sprite[] diceSides;

    // Reference to sprite renderer to change sprites
    private SpriteRenderer rend;

	// Use this for initialization
	private void Start () {

        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();

        // Load dice sides sprites to array from DiceSides subfolder of Resources folder
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
	}
	
    // If you left click over the dice then RollTheDice coroutine is started
    private void OnMouseDown()
    {
        StartCoroutine("RollTheDice");
    }

    // Coroutine that rolls the dice
    public IEnumerator RollTheDice()
    {
        // Variable to contain random dice side number.
        // It needs to be assigned. Let it be 0 initially
        randomDiceSide1 = 0;

        // Final side or value that dice reads in the end of coroutine
        finalSide1 = 0;

        // Loop to switch dice sides ramdomly
        // before final side appears. 20 itterations here.
        for (int i = 0; i <= 20; i++)
        {
            // Pick up random value from 0 to 5 (All inclusive)
            randomDiceSide1 = Random.Range(0, 6);

            // Set sprite to upper face of dice from array according to random value
            rend.sprite = diceSides[randomDiceSide1];

            // Pause before next itteration
            yield return new WaitForSeconds(0.05f);
        }

        // Assigning final side so you can use this value later in your game
        // for player movement for example
        finalSide1 = randomDiceSide1 + 1;

        // Show final dice value in Console
        Debug.Log(finalSide1);
    }
}
