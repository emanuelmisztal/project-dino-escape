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
        cracked = false;
    }

    public void ChangeScanStatus() { cracked = true; }

    private IEnumerator Deny()
    {
        Debug.Log("Deny coroutine started");
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/scanner-red");
        Debug.Log("Changed FPID sprite to red");
        Debug.Log("Start waiting");
        yield return new WaitForSeconds(1.5f);
        Debug.Log("Waited for 3 seconds");
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/scanner");
        Debug.Log("Changed FPID sprite to normal");
    }

    private void OnMouseDown()
    {
        if (cracked)
        {
            Debug.Log("FPID is cracked, unlock");
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/scanner-green");
            door.ChangeProgressStatus(2);
        }
        else
        {
            Debug.Log("FPID is not cracked, start Deny coroutine");
            StartCoroutine("Deny");
        }
    }
}