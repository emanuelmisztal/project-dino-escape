using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMinigameEnter : PipesMinigame
{
    public void OnMouseDown()
    {
        initCameraPosition = MainCamera.transform.position; // save camera position when entering game
        MainCamera.transform.position = new Vector3(-0.12f, -18.53f, MainCamera.transform.position.z); // move to view with minigame
        Arrows.SetActive(false);
    }
}
