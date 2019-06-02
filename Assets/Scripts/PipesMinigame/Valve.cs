using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour
{
    public Pipe[] pipes;
    public GameObject TextMessagePipe;
    public GameObject background;
    public bool PipeIsWon = false;

    private float[] correctAngles1;
    private float[] correctAngles2;

    private void Start()
    {
        
        correctAngles1 = new float[23] { 360f, 0f, 360f, 360f, 360f, 90f, 270f, 360f, 360f, 360f, 0f, 90f, 180f, 360f, 360f, 360f, 0f, 90f, 180f, 360f, 360f, 90f, 270f };
        correctAngles2 = new float[23] { 360f, 0f, 90f, 180f, 360f, 90f, 270f, 0f, 0f, 180f, 0f, 90f, 270f, 0f, 360f, 360f, 90f, 90f, 270f, 360f, 0f, 180f, 360f };
    }

    private void OnMouseDown()
    {
        int i;

        Debug.Log("Checking first option");
        for (i = 0; i < 23; i++)
        {
            if (correctAngles1[i] != 360f)
            {
                if (pipes[i].transform.eulerAngles.z > correctAngles1[i] - 1f && pipes[i].transform.eulerAngles.z < correctAngles1[i] + 1f)
                {
                    Debug.Log("Checking pipe: " + pipes[i].name + " = " + pipes[i].transform.eulerAngles.z + " and correctAngles1[" + i + "]" + " = " + correctAngles1[i] + " -> correct");
                    continue;
                }
                else
                {
                    Debug.Log("Checking pipe: " + pipes[i].name + " = " + pipes[i].transform.eulerAngles.z + " and correctAngles2[" + i + "]" + " = " + correctAngles1[i] + " -> incorrect");
                    break;
                }
            }
            else continue;
        }

        if (i >= 23)
        {
            TextMessagePipe.SetActive(true);
            background.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Backgrounds/ściana3 - naprawione rury");
            PipeIsWon = true;
            Debug.Log("Pipe minigame completed succesfuly");
            return;
        }

        Debug.Log("Checking second option");
        for (i = 0; i < 23; i++)
        {
            if (correctAngles2[i] != 360f)
            {
                if (pipes[i].transform.eulerAngles.z > correctAngles2[i] - 1f && pipes[i].transform.eulerAngles.z < correctAngles2[i] + 1f)
                {
                    Debug.Log("Checking pipe: " + pipes[i].name + " = " + pipes[i].transform.eulerAngles.z + " and correctAngles1[" + i + "]" + " = " + correctAngles2[i] + " -> correct");
                    continue;
                }
                else
                {
                    Debug.Log("Checking pipe: " + pipes[i].name + " = " + pipes[i].transform.eulerAngles.z + " and correctAngles1[" + i + "]" + " = " + correctAngles2[2] + " -> incorrect");
                    break;
                }
            }
            else continue;
        }

        if (i >= 23)
        {
            TextMessagePipe.SetActive(true);
            background.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Backgrounds/ściana3 - naprawione rury");
            Debug.Log("Pipe minigame completed succesfuly");
            return;
        }
        else
        {
            Debug.Log("Pipe minigame wrong combination");
            return;
        }
    }
}
