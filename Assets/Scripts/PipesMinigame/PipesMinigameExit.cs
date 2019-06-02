using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMinigameExit : PipesMinigame
{
    public void OnMouseDown()
    {
        MainCamera.transform.position = initCameraPosition;
        Arrows.SetActive(true);
    }
}