/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackArrow : MonoBehaviour
{
    public CameraController cameraController;
    public GameObject Arrows;

    public float BackTarget;

    private void OnMouseDown()
    {
        cameraController.MoveCameraTo(BackTarget);
        UpdateArrowsVisibility();
    }

    private void UpdateArrowsVisibility()
    {
        Arrows.SetActive(true);
    }
}
