/*
 * Author: Emanuel Misztal
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject[] locks; // link to looks on door

    public bool[] progress; // checklist for completed quests - opened locks

    private void Start()
    {
        progress = new bool[4] { false, false, false, false }; // reset progress at start
        foreach (GameObject go in locks)
        {
            go.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/NonInteractive/czerwona-lampka"); // change all locks sprites to locked
            go.SetActive(false);
        }
    }

    public void ActivatePanel()
    {
        foreach (GameObject go in locks) go.SetActive(true);
    }

    // when quest is completed
    public void ChangeProgressStatus(short id)
    {
        locks[id].gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/NonInteractive/zielona-lampka"); // load unlocked lock sprite
        progress[id] = true; // check in progress array

        if (progress[0] && progress[1] && progress[2] && progress[3])
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            GameObject.FindGameObjectWithTag("panelscienny").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Backgrounds/s1-kod-otwarte-drzwi");
        }
    }

    private void OnMouseDown()
    {
        if (progress[0] && progress[1] && progress[2] && progress[3]) SceneManager.LoadScene("GameOver");
    }
}
