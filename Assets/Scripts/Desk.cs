/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk : MonoBehaviour
{

    public CameraController cameraController;
    public GameObject Arrows;

    public float BackTarget;
    public BackArrow backArrow;

    private void OnMouseDown()
    {
        cameraController.MoveCameraTo(60.75f);
        backArrow.BackTarget = BackTarget;

        UpdateArrowsVisibility();
    }

    private void UpdateArrowsVisibility()
    {
        Arrows.SetActive(false);
    }
}
