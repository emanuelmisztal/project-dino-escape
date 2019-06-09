/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackArrowWires : MonoBehaviour
{
    public Camera MainCamera;

    public void OnMouseDown()
    {
        MainCamera.transform.position = new Vector3(80f, MainCamera.transform.position.y, MainCamera.transform.position.z);
    }
}
