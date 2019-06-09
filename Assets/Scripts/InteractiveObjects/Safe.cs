/*
 * Author: Emanuel Misztal
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : MonoBehaviour
{
    public CollectableObject key; // object stored in safe

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/safe"); // at the begining safe is closed so load this sprite
    }

    // open safe
    public void OpenSafe()
    {
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/safe-open"); // load opened safe sprite
        key.gameObject.SetActive(true); // show key (activate object)
    }
}
