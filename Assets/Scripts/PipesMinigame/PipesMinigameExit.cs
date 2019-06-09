/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMinigameExit : PipesMinigame
{
    public void OnMouseDown()
    {
        MainCamera.transform.position = initCameraPosition; // exit from minigame
        Arrows.SetActive(true); // show arrows
    }
}