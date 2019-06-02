using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject[] locks; // link to looks on door

    public bool[] progress; // checklist for completed quests - opened locks

    private void Start()
    {
        progress = new bool[4] { false, false, false, false }; // reset progress at start
        foreach (GameObject go in locks) go.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/locked"); // change all locks sprites to locked
    }

    public void ChangeProgressStatus(short id)
    {
        locks[id].gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/unlocked");
        progress[id] = true;
    }
}
