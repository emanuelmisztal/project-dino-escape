using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GetComponent<SpriteRenderer>().sprite.name == "pipe-knee")
        {
            switch (transform.eulerAngles.z)
            {
                case 0f:
                    transform.eulerAngles = new Vector3(0f, 0f, 90f);
                    break;
                case 90f:
                    transform.eulerAngles = new Vector3(0f, 0f, 180f);
                    break;
                case 180f:
                    transform.eulerAngles = new Vector3(0f, 0f, 270f);
                    break;
                case 270f:
                    transform.eulerAngles = new Vector3(0f, 0f, 0f);
                    break;
                default:
                    Debug.Log("wrong pipe rotation");
                    break;
            }
        }
        else
        {
            switch (transform.eulerAngles.z)
            {
                case 0f:
                    transform.eulerAngles = new Vector3(0f, 0f, 90f);
                    break;
                case 90f:
                    transform.eulerAngles = new Vector3(0f, 0f, 0f);
                    break;
                default:
                    Debug.Log("wrong pipe rotation");
                    break;
            }
        }
    }
}
