using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Digit : MonoBehaviour
{
    public CodePanel panel; // link to pin panel

    // when pressed send digit to display
    private void OnMouseDown()
    {
        switch (this.name)
        {
            case "V":
                panel.CheckPin();
                break;
            case "X":
                panel.Reset();
                break;
            default:
                panel.InputDigit(this.GetComponent<SpriteRenderer>().sprite);
                break;
        }
    }
}
