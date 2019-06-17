/*
 * Author: Emanuel Misztal
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoSkeleton : MonoBehaviour
{
    public Equipment eq; // link to eq

    private void OnMouseDown()
    {
        // check if player selected charged uv light from inventory
        if (eq.items[2] != null && eq.items[2].GetIsSelected() && eq.items[2].gameObject.GetComponent<SpriteRenderer>().sprite.name == "latarka-charged")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/s4-0plakat-zlatarka"); // uncover the truth
            eq.items[2].ChangeIsSelectedStatus(); // unselect uv light
        }
    }
}
