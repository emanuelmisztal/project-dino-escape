/*
 * Author: Emanuel Misztal
 * 2019
 *                         _
 *          ,---.          U
 *         ;     \         ;
 *     .==\"/==.  `-.___.-'
 *    ((+) .  .:)
 *    |`.-(o)-.'|
 *    \/  \_/  \/
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GetComponent<SpriteRenderer>().sprite.name == "rurakolanko") // if it's pipe knee
        {
            float angle = transform.eulerAngles.z;

            if (angle > 89f && angle < 91f) transform.eulerAngles = new Vector3(0f, 0f, 180f); 
            else if (angle > 179f && angle < 181f) transform.eulerAngles = new Vector3(0f, 0f, 270f);
            else if (angle > 269f && angle < 271f) transform.eulerAngles = new Vector3(0f, 0f, 0f);
            else transform.eulerAngles = new Vector3(0f, 0f, 90f);
        }
        else // it's straight pipe
        {
            float angle = transform.eulerAngles.z;

            if (angle > -1f && angle < 1f) transform.eulerAngles = new Vector3(0f, 0f, 90f);
            else transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
    }
}
