/*
 * Author: Emanuel Misztal
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{

    public bool[] stuff; // each item in list has index corresponding to item id
    public Radio radio; // link to radio - change to delegate in future - on the other hand, fuck it, shits working

    public CollectableObject[] items; // list of items - change to delegate in future

    void Start()
    {
        stuff = new bool[6] { false, false, false, false, false, false }; // do not change test to items[x] != null becouse items is private
        items = new CollectableObject[6] { null, null, null, null, null, null}; // create empty item list
    }

    // add item to equipment
    public void AddToEq(short id, CollectableObject co) // get id of item and game object
    {
        stuff[id] = true; // mark as in equipment
        items[id] = co; // link item to items list
    }

    // combine items in equipment
    public void Combine()
    {
        if (radio.GetIsSelected() && items[0] != null && items[0].GetIsSelected()) // if radio and first battery are selected
        {
            radio.AddBattery(); // invoke AddBattery method from Radio to attached radio
            items[0].gameObject.SetActive(false); // mark battery as inactive
            items[0] = null; // delete battery link from equipment
            stuff[0] = false; // mark battery as not in equipment
        }

        if (items[1] != null && items[1].GetIsSelected() && items[2] != null && items[2].GetIsSelected()) // if uv light and second battery are selected
        {
            items[2].GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/latarka-charged"); // change UV light sprite to charged sprite
            items[2].ChangeIsSelectedStatus(); // unselect UV light
            items[1].gameObject.SetActive(false); // mark battery as inactive
            items[1] = null; // delete battery link from equipment
            stuff[1] = false; // mark battery as not in equipment
        }

        if (items[2] != null && items[2].GetIsSelected() && items[2].GetComponent<SpriteRenderer>().sprite.name == "latarka-charged" && items[3] != null && items[3].GetIsSelected() && items[3].GetComponent<SpriteRenderer>().sprite.name == "note") // combine charged uv light with undecoded note
        {
            items[3].gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/note-code"); // load decoded note sprite
            items[2].ChangeIsSelectedStatus(); // unselect UV light
            items[3].ChangeIsSelectedStatus(); // unselect note
        }
        // define other cases

        // redifine case scenario don wrong combination
        // foreach (CollectableObject item in items) if (item != null && item.GetIsSelected()) item.ChangeIsSelectedStatus(); // on wrong combination or if success, deselect all selected items
    }

    // On changing camera view
    public void ChangePosition(float offset)
    {
        transform.position = new Vector3(gameObject.transform.position.x + offset, transform.position.y, transform.position.z); // change position of equipment background
        radio.transform.position = new Vector3(radio.transform.position.x + offset, radio.transform.position.y, radio.transform.position.z); // change position of radio
        
        // now change position of other items
        foreach (CollectableObject item in items)
        {
            if (item != null) item.transform.position = new Vector3(item.transform.position.x + offset, item.transform.position.y, item.transform.position.z); // change position of item
        }
    }
}
