/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackArrowMainMenu : MonoBehaviour
{
    public Camera MainCamera;
    private float delta = 20.25f;

    private void OnMouseDown()
    {
        MainCamera.transform.position = new Vector3(MainCamera.transform.position.x - delta, MainCamera.transform.position.y, MainCamera.transform.position.z);
    }
}
