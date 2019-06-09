/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiresMinigame : MonoBehaviour
{
    public Camera MainCamera;
    public GameObject Arrows;

    public void OnMouseDown()
    {
        MainCamera.transform.position = new Vector3(-81f, MainCamera.transform.position.y, MainCamera.transform.position.z);
        UpdateArrowsVisibility();
    }

    private void UpdateArrowsVisibility()
    {
        Arrows.SetActive(false);
    }
}