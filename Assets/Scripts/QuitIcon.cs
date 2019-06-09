/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitIcon : MonoBehaviour
{
    public GameObject inputField;
    public Camera MainCamera;
    public Equipment Eq;

    private void OnMouseDown()
    {
        inputField.gameObject.SetActive(false); // disable input field if it was displayed
        MainCamera.transform.position = new Vector3(40.5f, MainCamera.transform.position.y, MainCamera.transform.position.z);
        Eq.ChangePosition(101.25f);
    }
}
