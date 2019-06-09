/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingCameraView : MonoBehaviour
{
    public GameObject RightArrow;
    public GameObject LeftArrow;
    public Equipment eq;

    float delta = 20.25f;

    public void OnRightArrowClicked()
    {
        if(GetIsMaxToTheRight())
        {
            transform.position = new Vector3(-40.5f, transform.position.y, transform.position.z);
            eq.ChangePosition(-60.75f);
        }
        else
        {
            transform.position = new Vector3(gameObject.transform.position.x + delta, transform.position.y, transform.position.z);
            eq.ChangePosition(20.25f); // change position of equipment
        }
    }

    public void OnLeftArrowClicked()
    {
        if (GetIsMaxToTheLeft())
        {
            transform.position = new Vector3(20.25f, transform.position.y, transform.position.z);
            eq.ChangePosition(60.75f);
        }
        else
        {
            transform.position = new Vector3(gameObject.transform.position.x - delta, transform.position.y, transform.position.z);
            eq.ChangePosition(-20.25f); // change position of equipment
        }
    }

    private bool GetIsMaxToTheRight()
    {
        return Mathf.Approximately(gameObject.transform.position.x, 20.25f);
    }

    private bool GetIsMaxToTheLeft()
    {
        return Mathf.Approximately(gameObject.transform.position.x, -40.5f);
    }
}