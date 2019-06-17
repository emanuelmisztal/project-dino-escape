/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiresMinigameWinGuard : MonoBehaviour
{
    public ActivityGuard[] activityGuard;
    public bool WiresMinigameIsWon = false;
    public Door door;
    public GameObject LightningEffects;
    public GameObject TextMessageWires;

    public GameObject[] ColliderPinPanel;

    public void IsWiresMinigameWon()
    {
        if(WiresMinigameIsWon == true)
        {
            return;
        }

        if(activityGuard[0].FinishNumberIsActive == true && activityGuard[1].FinishNumberIsActive == true && activityGuard[2].FinishNumberIsActive == true)
        {
            WonWiresMinigame();
        }
    }

    public void WonWiresMinigame()
    {
        WiresMinigameIsWon = true;
        LightningEffects.SetActive(false);
        TextMessageWires.SetActive(true);
        GameObject.FindObjectOfType<Door>().ActivatePanel();
        GameObject.FindGameObjectWithTag("panelscienny").gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Backgrounds/s1-kod-działa");

        for (int i = 0; i < ColliderPinPanel.Length; i++)
        {
            ColliderPinPanel[i].GetComponent<BoxCollider2D>().enabled = true;
        }

        door.ChangeProgressStatus(1);
    }
}
