using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodePanel : MonoBehaviour
{
    private short inDigits; // count how many digits are on display

    public GameObject[] displayFields; // display positions
    public string correctPin;

    // Start is called before the first frame update
    void Start()
    {
        Reset(); // fill display with *
        inDigits = 0;
    }

    // Input digit
    public void InputDigit(Sprite sprite)
    {
        if (inDigits < 4)
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

        inDigits = 0;
    }

    public virtual void CheckPin() { }
}

public class PinPanel : CodePanel
{
    public GameObject safe; // link to safe
    public GameObject key; // link to key
    
    // check pin
    public override void CheckPin()
    {
        string pin = "";

        foreach (GameObject go in displayFields)
        {
            pin += go.GetComponent<SpriteRenderer>().sprite.name;
        }

        if (pin == correctPin)
        {
            safe.SetActive(true); // open linked safe
            key.SetActive(true); // show key
            gameObject.SetActive(false); // hide pin panel
        }
        else Reset();
    }
}
