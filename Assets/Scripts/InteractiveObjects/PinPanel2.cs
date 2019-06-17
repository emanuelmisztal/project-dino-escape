/*
 * Author: Emanuel Misztal
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinPanel2 : CodePanel
{
    public Door door; // link to door

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
            door.ChangeProgressStatus(0); // open linked safe
            //this.gameObject.SetActive(false); // hide pin panel
        }
        else Reset(); // reset panel screen
    }
}
