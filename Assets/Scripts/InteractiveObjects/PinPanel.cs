/*
 * Author: Emanuel Misztal
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodePanel : MonoBehaviour
{
    private short inDigits; // count how many digits are on display

    public GameObject[] displayFields; // display positions
    public string correctPin; // set correct pin

    // Start is called before the first frame update
    void Start()
    {
        Reset(); // fill display with *
        inDigits = 0; // how many digits are already on screen
    }

    // Input digit
    public void InputDigit(Sprite sprite)
    {
        if (inDigits < 4) // check if number of digits exceded screen capacity
        {
            displayFields[inDigits].GetComponent<SpriteRenderer>().sprite = sprite; // if display isn't full change first empty (*) field
            inDigits++; // increment digit counter
        }
    }

    // Reset display with *
    public void Reset()
    {
        foreach (GameObject go in displayFields) // for each field in display
        {
            go.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/PinPanel/star"); // load (*) sprite
        }

        inDigits = 0; // reset counter
    }

    public virtual void CheckPin() { } // interface for child clases
}

public class PinPanel : CodePanel
{
    public GameObject key; // link to key
    
    // check pin
    public override void CheckPin()
    {
        string pin = ""; // create empty string

        // read every digit from screen
        foreach (GameObject go in displayFields)
        {
            pin += go.GetComponent<SpriteRenderer>().sprite.name; // add digit to string
        }

        // check if pin is right
        if (pin == correctPin)
        {
            key.SetActive(true); // show key
            GameObject.FindGameObjectWithTag("tlosejf").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Backgrounds/s4-sejf-otwarty");
            gameObject.SetActive(false); // hide pin panel
        }
        else Reset(); // reset panel screen
    }
}
