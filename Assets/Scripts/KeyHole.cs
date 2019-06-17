using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHole : MonoBehaviour
{
    public Equipment eq;

    private void OnMouseDown()
    {
        if (GameObject.FindObjectOfType<Equipment>().items[5] != null && GameObject.FindObjectOfType<Equipment>().items[5].GetIsSelected() && GameObject.FindObjectOfType<WiresMinigameWinGuard>().WiresMinigameIsWon)
        {
            GameObject.FindObjectOfType<Door>().ChangeProgressStatus(3);
            eq.items[5].gameObject.SetActive(false);
            eq.items[5] = null;
            eq.stuff[5] = false;
        }
    }
}
