/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsOrder : MonoBehaviour
{
    public Door door;
    public Radio radio;

    public void CloudsRightOrder()
    {
        if(door.progress[1] == false)
        {
            radio.FirstComicCloud.SetActive(true);
        }
        else if(door.progress[2] == false)
        {
            radio.SecondComicCloud.SetActive(true);
        }
        else if (door.progress[0] == false)
        {
            radio.ThirdComicCloud.SetActive(true);
        }
        else if (door.progress[3] == false)
        {
            radio.FourthComicCloud.SetActive(true);
        }
        else
        {
            //Jakis dymek ze swietnie sobie radzisz sam
        }
    }
}