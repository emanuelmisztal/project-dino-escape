/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionWithPlug : MonoBehaviour
{
    public bool IsPlugConnected = false;
    public int IdSocket = 0;
    public ActivityGuard activityGuard;

    private MoveObject moveObject;
    private GameObject whatIsConnectedTo;
    private Coroutine coroutine;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("plug"))
        {
            if(IsPlugConnected == true)
            {
                return;
            }
            else
            {
                IsPlugConnected = true;
                whatIsConnectedTo = other.gameObject;
                IdSocket = other.gameObject.GetComponent<MoveObject>().IdNumber;
                other.gameObject.GetComponentInParent<ChangingActivityStatus>().OnConnected();
                activityGuard.ChangingActivity();

                other.gameObject.GetComponent<MoveObject>().IsMovingEnabled = false;
                other.gameObject.transform.position = transform.position;
                coroutine = StartCoroutine(COR_ForcePositions(transform, other.gameObject.transform));
            }
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if(whatIsConnectedTo == other.gameObject)
        {
            IsPlugConnected = false;
            IdSocket = 0;
            other.gameObject.GetComponentInParent<ChangingActivityStatus>().OnDisconnected();
            activityGuard.ChangingActivity();
        }
    }

    private IEnumerator COR_ForcePositions(Transform target, Transform objectToMove)
    {
        while(objectToMove.GetComponent<MoveObject>().IsMovingEnabled == false)
        {
            objectToMove.position = target.position;
            yield return null;
        }
    }
}