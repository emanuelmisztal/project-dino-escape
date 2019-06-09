/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangingActivityStatus : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public TextMeshPro NumberText;
    public int IdNumber;

    public void OnConnected()
    {
        spriteRenderer.sprite = Resources.Load<Sprite>("Sprites/WiresMinigame/CorrectBackground");
        NumberText.color = Color.green;
    }

    public void OnDisconnected()
    {
        spriteRenderer.sprite = Resources.Load<Sprite>("Sprites/WiresMinigame/WrongBackground");
        NumberText.color = Color.red;
    }
}