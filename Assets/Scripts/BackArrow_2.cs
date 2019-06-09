/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackArrow_2 : MonoBehaviour
{
    public Camera MainCamera;
    public Equipment Eq;
    public GameObject Arrows;

    private void OnMouseDown()
    {
        MainCamera.transform.position = new Vector3(MainCamera.transform.position.x + 60.75f, MainCamera.transform.position.y, MainCamera.transform.position.z);
        Eq.ChangePosition(60.75f);
        UpdateLeftArrowsVisibility();
    }

    private void UpdateLeftArrowsVisibility()
    {
        Arrows.SetActive(true);
    }
}
