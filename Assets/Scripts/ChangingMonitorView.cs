/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingMonitorView : MonoBehaviour
{
    public CameraController cameraController;
    public GameObject Arrows;

    private void OnMouseDown()
    {
        cameraController.MoveCameraTo(-60.75f);

        UpdateArrowsVisibility();
    }

    private void UpdateArrowsVisibility()
    {
        Arrows.SetActive(false);
    }
}