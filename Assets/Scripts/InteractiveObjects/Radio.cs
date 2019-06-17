/*
 * Author: Kaja Więckowska, Emanuel Misztal
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Only for radio item
public class Radio : CollectableObject // inherits from CollectableObject because it is in equipment
{
    enum BatteryLevel { DEP, LOW, MID, HIGH}; // enum list with battery levels (depleted, low, medium, high)

    private BatteryLevel batteryStatus; // variable of type BatteryLevel storing current battery level

    // links to comic clouds with tips
    public GameObject FirstComicCloud;
    public GameObject SecondComicCloud;
    public GameObject ThirdComicCloud;
    public GameObject FourthComicCloud;
    public GameObject FifthComicCloud;

    // link to tip clouds order object
    public CloudsOrder comicCloud;

    void Start()
    {
        batteryStatus = BatteryLevel.DEP; // default battery level is DEP
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/intercom-depleted"); // load depleted sprite
    }

    // when batery is inserted in
    public void AddBattery()
    {
        batteryStatus = BatteryLevel.HIGH; // change battery status to high
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/intercom-full"); // load full battery sprite
    }

    // OnMouseDown
    public void OnMouseDown()
    {
        switch (batteryStatus) // check battery status
        {
            case BatteryLevel.DEP: // battery is depleted
                isSelected = true; // mark selected for combine
                equipment.Combine(); // invoke combine method
                isSelected = false; // mark deselected
                ThirdComicCloud.SetActive(false);
                break;

            case BatteryLevel.LOW: // battery is low
                SecondComicCloud.SetActive(false);
                batteryStatus = BatteryLevel.DEP; // change battery status to depleted
                gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/intercom-depleted"); // load depleted sprite
                ThirdComicCloud.SetActive(true);
                break;

            case BatteryLevel.MID: // battery is medium
                FirstComicCloud.SetActive(false);
                batteryStatus = BatteryLevel.LOW; // change battery status to low
                SecondComicCloud.SetActive(true);
                break;

            case BatteryLevel.HIGH: // battery is high
                batteryStatus = BatteryLevel.MID; // change battery status to medium
                FirstComicCloud.SetActive(true);
                break;
        }
    }
}
