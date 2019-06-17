/*
 * Author: Emanuel Misztal
 * 2019
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
    public GameObject inputField; // input field where player should input password

    private short clickCount; // click counter

    // Start is called before the first frame update
    void Start()
    {
        clickCount = 0; // set click count to 0
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/DisplayMonitor/icon"); // load icon sprite
    }

    // reset click counter
    public void ResetClickCounter()
    {
        clickCount = 0; // reset click count to 0
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/DisplayMonitor/icon"); // load icon sprite
    }

    private void OnMouseDown()
    {
        switch (clickCount) // check how many times player clicked on icon
        {
            case 0: // if not once
                clickCount = 1; // increment to 1 click
                GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/DisplayMonitor/icon-selected"); // load selected icon sprite
                break;
            case 1:
                clickCount = 0; // reset back to 0
                GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/DisplayMonitor/icon"); // load selected icon sprite
                inputField.gameObject.SetActive(true); // show input field for password
                break;
            default:
                Debug.LogWarning("Something went wrong in " + this.gameObject);
                break;
        }
    }
}
