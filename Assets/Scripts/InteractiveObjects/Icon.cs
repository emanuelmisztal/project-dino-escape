using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
    public GameObject inputField;

    private short clickCount; // click counter

    // Start is called before the first frame update
    void Start()
    {
        clickCount = 0;
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/DisplayMonitor/icon"); // load icon sprite
    }

    // reset click counter
    public void ResetClickCounter()
    {
        clickCount = 0;
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/DisplayMonitor/icon"); // load icon sprite
    }

    private void OnMouseDown()
    {
        switch (clickCount)
        {
            case 0:
                clickCount = 1;
                GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/DisplayMonitor/icon-selected"); // load selected icon sprite
                break;
            case 1:
                clickCount = 0;
                GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/DisplayMonitor/icon"); // load selected icon sprite
                inputField.gameObject.SetActive(true); // show input field for password
                break;
            default:
                break;
        }
    }
}
