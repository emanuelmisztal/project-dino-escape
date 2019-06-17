/*
 * Author: Emanuel Misztal
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hover : MonoBehaviour
{
    public string tipText; // text explaining thing it's curently hovering over

    private Text hover; // text component

    private void OnMouseEnter()
    {
        hover = GameObject.Find("Canvas/ExplainText").gameObject.GetComponent<Text>(); // get text component
        hover.text = tipText; // input text
    }

    /*
    void OnMouseOver()
    {
        //hover.transform.position = new Vector3(Input.mousePosition.x / 1000, Input.mousePosition.y / 1000, -1f);
    }
    */

    void OnMouseExit()
    {
        hover.text = "";
    }
}
