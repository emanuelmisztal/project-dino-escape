/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public bool IsMovingEnabled { get; set; }
    public Rope hookPosition;

    float distance = 2.757f;
    public float DistanceY = 100f;
    public int IdNumber;
    public GameObject MainSocket;
    public WiresMinigameWinGuard WiresWinGuard;

    private void Start()
    {
        gameObject.transform.position = new Vector3(hookPosition.transform.position.x - DistanceY, hookPosition.transform.position.y - DistanceY, 0);
        IdNumber = GetComponentInParent<ChangingActivityStatus>().IdNumber;

        if(IdNumber == 17 || IdNumber == 19 || IdNumber == 2)
        {
            gameObject.transform.position = MainSocket.transform.position;
            StartCoroutine(SetPlugPosition());
            this.enabled = false;
        }
    }

    private void Awake()
    {
        IsMovingEnabled = true;
    }

    private void OnMouseDown()
    {
        IsMovingEnabled = true;
    }

    private void OnMouseDrag()
    {
        if (!IsMovingEnabled || WiresWinGuard.WiresMinigameIsWon == true)
        {
            return;
        }

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;
    }

    private IEnumerator SetPlugPosition()
    {
        while(true)
        {
            yield return null;
            gameObject.transform.position = MainSocket.transform.position;
        }
    }
}
