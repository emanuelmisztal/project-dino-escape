/*
 * Author: Emanuel Misztal
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// All collectable object should have assigned or inherit this class
public class CollectableObject : MonoBehaviour
{
    public short id; // item id
    public Equipment equipment; // link to eq - should be changed to delegate in future

    protected bool isSelected; // is this item selected - it has to be already in equipment to be selected

    private void Start()
    {
        isSelected = false; // item is not selected
    }

    // OnMouseDown
    void OnMouseDown()
    {
        if (!equipment.stuff[id]) // if item is not in equipment
        {
            equipment.AddToEq(id, this); // add to equipment table
            switch (id) // check item id
            {
                case 0: // it's a battery for radio
                    transform.Rotate(new Vector3(0, 0, 90)); // rotate to horizontal
                    transform.position = new Vector3(40.5f, -4.4f, 0.0f); // place in second equipment box
                    break;

                case 1: // battery for uv light
                    transform.Rotate(new Vector3(0, 0, 90)); // rotate to horizontal
                    transform.position = new Vector3(43f, -4.4f, 0.0f); // place in third equipment box
                    break;

                case 2: // uv light
                    transform.position = new Vector3(45.35f, -4.4f, 0.0f); // place in fourth equipment box
                    break;

                case 3: // note and key
                    transform.position = new Vector3(-96f, -4.4f, 0.0f); // it's a key, place in fifth eqipment box
                    break;

                case 4: // Egg
                    transform.position = new Vector3(-23.5f, -4.4f, 0.0f); // place in first equipment box
                    break;

                case 5:
                    transform.localScale += new Vector3(0.05f, 0.05f, 0);
                    transform.position = new Vector3(13.5f, -4.4f, 0.0f);
                    break;
                default: // all other items (nothing) - all items should be implemented in future
                    break;
            }
        }
        else  if (id != -1) ChangeIsSelectedStatus(); // if item is in equipment and it's not radio, change selected status to not selected
    }

    // change isSelected status
    public void ChangeIsSelectedStatus()
    {
        if (!isSelected) // item is selected
        {
            transform.localScale = transform.localScale * 2.0f; // increse size of item to indicate that it is selected
            isSelected = true; // mark item as selected
            equipment.Combine(); // invoke combine method from equipment
        }
        else // item is not selected
        {
            transform.localScale = transform.localScale * 0.5f; // decrese size of item to indicate that it is not selected anymore
            isSelected = false; // mark as not selected
        }
    }

    public bool GetIsSelected() { return isSelected; } // return true if item is selected
}
