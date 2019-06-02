using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hover : MonoBehaviour
{
    public string tipText;

    private Text hover;

    private void OnMouseEnter()
    {
        hover = GameObject.Find("Canvas/ExplainText").gameObject.GetComponent<Text>();
        hover.text = tipText;
    }

    void OnMouseOver()
    {
        //hover.transform.position = new Vector3(Input.mousePosition.x / 1000, Input.mousePosition.y / 1000, -1f);
    }

    void OnMouseExit()
    {
        hover.text = "";
    }
}
