/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public static GameMaster Instance { get; private set; } // singleton of gamemaster

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // when time is over
    public void ShowGameOver()
    {
        SceneManager.LoadScene("GameOver"); // load game over scene
    }
    // when time is won
    public void ShowGameWon()
    {
        SceneManager.LoadScene("GameWon"); // load game won scene
    }
}
