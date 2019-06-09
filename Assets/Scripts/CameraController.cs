/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera MainCamera;
    public Equipment Eq;

    public void MoveCameraBy(float delta)
    {
        MainCamera.transform.position = new Vector3(MainCamera.transform.position.x + delta, MainCamera.transform.position.y, MainCamera.transform.position.z);
        Eq.ChangePosition(delta);
    }

    public void MoveCameraTo(float targetPos)
    {
        float delta = targetPos - MainCamera.transform.position.x;
        MoveCameraBy(delta);
    }
}
