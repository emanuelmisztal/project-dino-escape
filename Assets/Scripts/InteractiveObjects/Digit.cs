/*
 * Author: Emanuel Misztal
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Digit : MonoBehaviour
{
    public CodePanel panel; // link to pin panel

    // when pressed send digit to display
    private void OnMouseDown()
    {
        // check wich button was pressed
        switch (this.name)
        {
            case "V": // acceptation button
                panel.CheckPin(); // check if pin is right
                break;
            case "X": // clear button
                panel.Reset(); // clear panel screen
                break;
            default: // digits
                panel.InputDigit(this.GetComponent<SpriteRenderer>().sprite); // put digit on panel screen
                break;
        }
    }
}
