using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CharacterSelectScript : MonoBehaviour
{
    public GameObject player1Character1;
    public GameObject player1Character2;
    public GameObject player2Character1;
    public GameObject player2Character2;
    public TMP_InputField inputP1Name;
    public TMP_InputField inputP2Name;

    public void SetPlayer1Name()
    {
        if (player1Character1.GetComponent<Toggle>().isOn == true) //default for p1
        {
            GameManager.player1name = inputP1Name.text;

        }
        else if (player1Character2.GetComponent<Toggle>().isOn == true) 
        {
            GameManager.player1name = inputP1Name.text;

        }
    }

    public void SetPlayer2Name()
    {
        if (player2Character1.GetComponent<Toggle>().isOn == true)
        {
            GameManager.player2name = inputP2Name.text;
        }
        else if (player2Character2.GetComponent<Toggle>().isOn == true) //default for p2
        {
            GameManager.player2name = inputP2Name.text;

        }
    }
    public void SetPlayerHP(int hp)
    {
        GameManager.player1hp = hp;
        GameManager.player2hp = hp;
        GameManager.playersmaxhp = hp;
    }

    public void StartFight()
    {
        SceneManager.LoadScene("P1Attack");
    }

  
}
