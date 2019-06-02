using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingViewToDesk : MonoBehaviour
{
    public CameraController cameraController;
    public GameObject Arrows;

    public float BackTarget;
    public BackArrow backArrow;

    private void OnMouseDown()
    {
        cameraController.MoveCameraTo(40.5f);
        backArrow.BackTarget = BackTarget;

        UpdateArrowsVisibility();
    }

    private void UpdateArrowsVisibility()
    {
        Arrows.SetActive(false);
    }
}
