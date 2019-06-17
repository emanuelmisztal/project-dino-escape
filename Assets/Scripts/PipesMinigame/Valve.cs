/*
 * Author: Kaja Więckowska, Emanuel Misztal
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour
{
    public Pipe[] pipes; // link to all pipes in minigame
    public GameObject TextMessagePipe; // link to text indicating completion of minigame
    public GameObject background; // link to background
    public bool PipeIsWon = false; // completion flag

    private float[] correctAngles1; // first array with correct angles
    private float[] correctAngles2; // second array with correct angles

    private void Start()
    {
        // initialize correct angles in arrays
        correctAngles1 = new float[23] { 360f, 0f, 360f, 360f, 360f, 90f, 270f, 360f, 360f, 360f, 0f, 90f, 180f, 360f, 360f, 360f, 0f, 90f, 180f, 360f, 360f, 90f, 270f };
        correctAngles2 = new float[23] { 360f, 0f, 90f, 180f, 360f, 90f, 270f, 0f, 0f, 180f, 0f, 90f, 270f, 0f, 360f, 360f, 90f, 90f, 270f, 360f, 0f, 180f, 360f };
    }

    private void OnMouseDown()
    {
        int i; // !!! most important variable in whole game, without it everything will colapse !!!

        // check if pipes are in right angles
        for (i = 0; i < 23; i++)
        {
            if (correctAngles1[i] != 360f)
            {
                if (pipes[i].transform.eulerAngles.z > correctAngles1[i] - 1f && pipes[i].transform.eulerAngles.z < correctAngles1[i] + 1f) continue;
                else break;
            }
            else continue;
        }

        // if pipes are correct
        if (i >= 23)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/PipesMinigame/zawór2");
            //gameObject.transform.position = new Vector3(-1.349f, -3.62f, 0.3164063f);
            TextMessagePipe.SetActive(true); // show copletion text
            //background.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Backgrounds/ściana3 - naprawione rury"); // load new background
            GameObject.FindGameObjectWithTag("pipeenter").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Backgrounds/s3-zbliżenie-kable-naprawione");
            PipeIsWon = true; // set flag
            return; // return from method
        }

        // check if pipes are in right angles
        for (i = 0; i < 23; i++)
        {
            if (correctAngles2[i] != 360f)
            {
                if (pipes[i].transform.eulerAngles.z > correctAngles2[i] - 1f && pipes[i].transform.eulerAngles.z < correctAngles2[i] + 1f) continue;
                else break;
            }
            else continue;
        }

        // if pipes are correct
        if (i >= 23)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/PipesMinigame/zawór2");
            //gameObject.transform.position = new Vector3(-1.349f, -3.62f, 0.3164063f);
            TextMessagePipe.SetActive(true); // show copletion text
            //background.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Backgrounds/ściana3 - naprawione rury"); // load new background
            GameObject.FindGameObjectWithTag("pipeenter").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Backgrounds/s3-zbliżenie-kable-naprawione");
            PipeIsWon = true; // set flag
            return; // return from method
        }
    }
}
