/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackArrowPinPanel : MonoBehaviour
{
    public Camera MainCamera;
    public GameObject Arrows;

    private void OnMouseDown()
    {
        MainCamera.transform.position = new Vector3(MainCamera.transform.position.x, MainCamera.transform.position.y - 10f, MainCamera.transform.position.z);

        UpdateArrowsVisibility();
    }

    private void UpdateArrowsVisibility()
    {
        Arrows.SetActive(true);
    }
}
