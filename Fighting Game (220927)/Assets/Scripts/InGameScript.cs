using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGameScript : MonoBehaviour
{
    public GameObject P1Hp;
    public GameObject P2Hp;
    public GameObject Player1Name;
    public GameObject Player2Name;
    public Slider p1HealthBar;
    public Slider p2HealthBar;


    void Start()
    {
        Player1Name.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.player1name + "";
        Player2Name.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.player2name + "";

        p1HealthBar.maxValue = GameManager.playersmaxhp;
        p2HealthBar.maxValue = GameManager.playersmaxhp;
    }

    void Update()
    {
        P1Hp.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.player1hp + "";
        P2Hp.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.player2hp + "";
        
        p1HealthBar.value = GameManager.player1hp;
        p2HealthBar.value = GameManager.player2hp;
    }
}