/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingViewToSafe : MonoBehaviour
{
    public CameraController cameraController;
    public GameObject Arrows;

    private void OnMouseDown()
    {
        cameraController.MoveCameraTo(-101.25f);

        UpdateArrowsVisibility();
    }

    private void UpdateArrowsVisibility()
    {
        Arrows.SetActive(false);
    }
}
