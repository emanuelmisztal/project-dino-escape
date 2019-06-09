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

    // Start is called before the first frame update
    void Start()
    {
        cracked = false; // at start scaner is not cracked
    }

    public void ChangeScanStatus() { cracked = true; } // cracket interface

    // indicate that player's input is invalid
    private IEnumerator Deny()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/scanner-red"); // highlight scanner red
        yield return new WaitForSeconds(1.5f); // wait for some short time
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/scanner"); // return scanner color to normal
    }

    private void OnMouseDown()
    {
        if (cracked) // if scanner was cracked
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/scanner-green"); // unlocked
            door.ChangeProgressStatus(2); // move in questline
        }
        else // if scanner wasn't cracked
        {
            StartCoroutine("Deny"); // start deny coroutine
        }
    }
}