/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PipesMinigame : MonoBehaviour
{
    public Camera MainCamera; // link to main camera
    public GameObject Arrows; // link to arrows

    protected static Vector3 initCameraPosition; // static camera position
}