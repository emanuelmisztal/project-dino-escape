/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityGuard : MonoBehaviour
{
    public ConnectionWithPlug[] Sockets;
    public ChangingActivityStatus changingActivityStatus;
    public WiresMinigameWinGuard wiresMinigameWinGuard;
    public int IdFinishNumber;
    public bool FinishNumberIsActive = false;

    public void ChangingActivity()
    {
        if (Sockets[0].IdSocket + Sockets[1].IdSocket + Sockets[2].IdSocket == IdFinishNumber)
        {
            StartCoroutine(Waiting());
            FinishNumberIsActive = true;
            wiresMinigameWinGuard.IsWiresMinigameWon();
        }
        else
        {
            changingActivityStatus.OnDisconnected();
            FinishNumberIsActive = false;
        }
    }

    private IEnumerator Waiting()
    {
        yield return new WaitForSecondsRealtime(2);
        changingActivityStatus.OnConnected();
    }
}
