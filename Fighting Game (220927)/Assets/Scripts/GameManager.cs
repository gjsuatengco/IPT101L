using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int player1hp;
    public static int player2hp;
    public static int playersmaxhp;

    //carries default placeholder names in case none is set
    public static string player1name = "Player 1";
    public static string player2name = "Player 2";

    //for on hit scene
    public static int dmgplaceholder;
    public static bool player1attacked;
    public static bool player2attacked;
    public static bool player1Hit;

    public static bool player2Hit;

    public static int moveType;

    //for win condition
    public static bool playerwin = false;
    
    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void DealDamageP1(int p2currentHp, int p1damage, int p1accuracy)
    {
        int rng = Random.Range(0,101);
        player2attacked = true;
        if (rng < p1accuracy)
        {
            player1Hit = true;
            dmgplaceholder = p1damage;
            SceneManager.LoadScene("SampleHit");
            player2hp = p2currentHp - p1damage;
        }
        else
        {
            player1Hit = false;
            SceneManager.LoadScene("SampleMiss");
        }
    }

    void DealDamageP2(int p1currentHp, int p2damage, int p2accuracy)
    {
        int rng = Random.Range(0,101);
        player1attacked = true;
        if (rng < p2accuracy)
        {
            player2Hit = true;
            dmgplaceholder = p2damage;
            SceneManager.LoadScene("SampleHit");
            player1hp = p1currentHp - p2damage;
            
        }
        else
        {
            player2Hit = false;
            SceneManager.LoadScene("SampleMiss");
        }
    }

    //Player 1 Attacks
    public void p1LowPunch()
        {
            moveType = 1;   
            DealDamageP1(player2hp, 3, 75);
        }

    public void p1HighPunch()
        {
            moveType = 2;
            DealDamageP1(player2hp, 8, 55);
        }

    public void p1LowKick()
        {
            moveType = 3; 
            DealDamageP1(player2hp, 6, 65);
        }

    public void p1HighKick()
        {
            moveType = 4;
            DealDamageP1(player2hp, 12, 45);
        }
    
    public void p1SpecialAtk()
        {
            moveType = 5;
            DealDamageP1(player2hp, 25, 100);
        }

    //Player 2 Attacks
    public void p2LowPunch()
        {
            moveType = 1;
            DealDamageP2(player1hp, 3, 75);
        }

    public void p2HighPunch()
        {
            moveType = 2;
            DealDamageP2(player1hp, 8, 55);
        }

    public void p2LowKick()
        {
            moveType = 3;
            DealDamageP2(player1hp, 6, 65);
        }

    public void p2HighKick()
        {
            moveType = 4;
            DealDamageP2(player1hp, 12, 45);
        }

    public void p2SpecialAtk()
        {
            moveType = 5;
            DealDamageP2(player1hp, 25, 100);
        }

      
}
