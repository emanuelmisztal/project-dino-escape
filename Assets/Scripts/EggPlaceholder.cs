/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggPlaceholder : MonoBehaviour
{
    public Equipment eq;

    private void OnMouseDown()
    {
        if (eq.items[4] != null && eq.items[4].GetIsSelected())
        {
            eq.items[4].gameObject.SetActive(false);
            eq.items[4] = null;
            eq.stuff[4] = false;
            // change background
        }
    }
}
