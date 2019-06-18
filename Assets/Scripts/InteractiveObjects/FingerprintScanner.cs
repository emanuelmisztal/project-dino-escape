/*
 * Author: Emanuel Misztal
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerprintScanner : MonoBehaviour
{
    public Door door; // link to door
    
    private bool cracked; // is fingerprint changed in PC
    private bool activated;

    // Start is called before the first frame update
    void Start()
    {
        cracked = false; // at start scaner is not cracked
        activated = false;
    }

    public void ChangeScanStatus() { cracked = true; } // cracked interface
    public void Activate() { activated = true; }

    // indicate that player's input is invalid
    private IEnumerator Deny()
    {
        GameObject.FindGameObjectWithTag("panelscienny").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Backgrounds/s1-kod-niedziala-czerwone");
        yield return new WaitForSeconds(1.5f); // wait for some short time
        GameObject.FindGameObjectWithTag("panelscienny").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Backgrounds/s1-kod-działa"); // return scanner color to normal
    }

    private void OnMouseDown()
    {
        Debug.Log("clicked");
        if (cracked && activated) // if scanner was cracked
        {
            Debug.Log("inside 1");
            GameObject.FindGameObjectWithTag("panelscienny").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Backgrounds/s1-kod-niedziala-działa"); // unlocked
            door.ChangeProgressStatus(2); // move in questline
        }
        else if (activated) // if scanner wasn't cracked
        {
            Debug.Log("inside 2");
            StartCoroutine("Deny"); // start deny coroutine
        }
    }
    /*
    private void OnMouseDown()
    {
        if (cracked && GameObject.FindObjectOfType<WiresMinigameWinGuard>().WiresMinigameIsWon == true) // if scanner was cracked
        {
            GameObject.FindGameObjectWithTag("panelscienny").gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Backgrounds/s1-kod-niedziala-działa"); // unlocked
            door.ChangeProgressStatus(2); // move in questline
        }
        else if (GameObject.FindObjectOfType<WiresMinigameWinGuard>().WiresMinigameIsWon == true) // if scanner wasn't cracked
        {
            StartCoroutine("Deny"); // start deny coroutine
        }
    }*/
}