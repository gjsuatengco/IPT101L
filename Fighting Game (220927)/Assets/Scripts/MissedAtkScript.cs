using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissedAtkScript : MonoBehaviour
{

    void Start()
    {
        Invoke("MissDelay", 2f);
    }

    void MissDelay()
    {
        if (GameManager.player1attacked == true)
        {
            GameManager.player1attacked = false;
            SceneManager.LoadScene("P1Attack");
        }
        else if (GameManager.player2attacked == true)
        {
            GameManager.player2attacked = false;
            SceneManager.LoadScene("P2Attack");
        }
    }
}
