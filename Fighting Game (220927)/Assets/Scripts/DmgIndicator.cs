using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class DmgIndicator : MonoBehaviour
{
    public GameObject Player2Hit;
    public GameObject Player1Hit;
    public GameObject VideoPlayerGO;
    public VideoClip vc1,vc2,vc3,vc4,vc5,vc6,vc7,vc8,vc9,vc10,vc11,vc12,vc13,vc14,vc15,vc16,vc17,vc18;


    void Start()
    {
        if (GameManager.player1hp <= 0 || GameManager.player2hp <= 0)
        {
            StartCoroutine(whatMove());
            Invoke("DelayAttack", 2);
            Player1Hit.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "";
            Player2Hit.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "";  

            GameManager.playerwin = true;
            
            StartCoroutine(WinSceneDelay());
        }
        else
        {
            StartCoroutine(whatMove());
            Invoke("DelayAttack", 2);
            Player1Hit.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "";
            Player2Hit.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = ""; 
        }    
    }
       

    void DelayAttack()
    {
         //displays damage value on hit screen
        if (GameManager.player2attacked == true)
        {
            Player1Hit.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "";
            Player2Hit.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "-" + GameManager.dmgplaceholder + "";
            GameManager.player2attacked = false;
        }
        if (GameManager.player1attacked == true)
        {
            Player2Hit.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "";
            Player1Hit.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "-" + GameManager.dmgplaceholder + "";
            GameManager.player1attacked = false;
        }
    }
    
 //video move list  
    IEnumerator whatMove(){
        // switch(GameManager.moveType)
            if(GameManager.moveType ==1)
            {
                if(GameManager.player2attacked) 
                {
                    if(GameManager.player1Hit == true)
                    { // p1 attack
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc1;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(3);
                        SceneManager.LoadScene("P2Attack");
                    }
                    else if(GameManager.player1Hit == false)
                    { //p1 attack miss
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc11;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(3);
                        SceneManager.LoadScene("P2Attack");
                    }
                } 
                else if(GameManager.player1attacked) 
                {
                    if(GameManager.player2Hit == true)
                    { // p2 attack
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc2;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(3);
                        SceneManager.LoadScene("P1Attack");
                    }
                    else if(GameManager.player2Hit == false)
                    { // p2 attack miss
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc12;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(4);
                        SceneManager.LoadScene("P1Attack");
                    }
                }
            } else if (GameManager.moveType ==2)
            {
                if(GameManager.player2attacked) 
                {
                    if(GameManager.player1Hit == true){ // p1 attack   
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc3;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(4);
                        SceneManager.LoadScene("P2Attack");
                    }
                    else if(GameManager.player1Hit == false)
                    { //p1 attack miss
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc13;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(3.5f);
                        SceneManager.LoadScene("P2Attack");
                    }
                } else if(GameManager.player1attacked) {
                    if(GameManager.player2Hit == true)
                    { // p2 attack
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc4;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(4.5f);
                        SceneManager.LoadScene("P1Attack");
                    }
                    else if(GameManager.player2Hit == false)
                    { // p2 attack miss
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc14;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(4f);
                        SceneManager.LoadScene("P1Attack");
                    }
                }
            } else if(GameManager.moveType ==3){
                if(GameManager.player2attacked) {
                    if(GameManager.player1Hit == true){ // p1 attack
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc5;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(3.5f);
                        SceneManager.LoadScene("P2Attack");
                }
                    else if(GameManager.player1Hit == false){ //p1 attack miss
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc15;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(3.5f);
                        SceneManager.LoadScene("P2Attack");
                }
                } else if(GameManager.player1attacked) {
                    if(GameManager.player2Hit == true){ // p2 attack
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc6;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(4f);
                        SceneManager.LoadScene("P1Attack");
                }
                    else if(GameManager.player2Hit == false){ // p2 attack miss
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc16;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(3f);
                        SceneManager.LoadScene("P1Attack");
                }
                }
            } else if(GameManager.moveType ==4){
                if(GameManager.player2attacked) {
                    if(GameManager.player1Hit == true){ // p1 attack
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc7;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(4);
                        SceneManager.LoadScene("P2Attack");
                }
                    else if(GameManager.player1Hit == false){ //p1 attack miss
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc17;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(3.5f);
                        SceneManager.LoadScene("P2Attack");
                }
                } else if(GameManager.player1attacked) {
                    if(GameManager.player2Hit == true){ // p2 attack
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc8;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(4);
                        SceneManager.LoadScene("P1Attack");
                }
                    else if(GameManager.player2Hit == false){ // p2 attack miss
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc18;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(4);
                        SceneManager.LoadScene("P1Attack");
                }
                }
            } else if(GameManager.moveType ==5){
                if(GameManager.player2attacked) {
                    if(GameManager.player1Hit == true){ // p1 attack
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc9;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(5);
                        SceneManager.LoadScene("P2Attack");
                }
                } else if(GameManager.player1attacked) {
                    if(GameManager.player2Hit == true){ // p2 attack
                        yield return new WaitForSeconds(0.2f);
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc10;
                        VideoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
                        yield return new WaitForSeconds(5);
                        SceneManager.LoadScene("P1Attack");
                    }
                }
            }
            GameManager.player1Hit = false;
            GameManager.player2Hit = false;
            GameManager.moveType = 0;
    }
    
    
    // IEnumerator DelayVideo2s(){
    //     yield return new WaitForSeconds(2);      
    // }
    
    // IEnumerator DelayVideo2sP1(){
    //     yield return new WaitForSeconds(3.5f);
    //     SceneManager.LoadScene("P2Attack");
    // }

    // IEnumerator DelayVideo3sP1(){
    //     yield return new WaitForSeconds(3.35f);
    //     SceneManager.LoadScene("P2Attack");
    // }

    // IEnumerator DelayVideo5sP1(){
    //     yield return new WaitForSeconds(15);
    //     SceneManager.LoadScene("P2Attack");
    // }

    // IEnumerator DelayVideo2sP2(){
    //     yield return new WaitForSeconds(3.5f);
    //     SceneManager.LoadScene("P1Attack");
    // }
    // IEnumerator DelayVideo3sP2(){
    //     yield return new WaitForSeconds(3.75f);
    //     SceneManager.LoadScene("P1Attack");
    // }

    // IEnumerator DelayVideo5sP2(){
    //     yield return new WaitForSeconds(15);
    //     SceneManager.LoadScene("P1Attack");
    // }

    IEnumerator WinSceneDelay(){
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Retry");
    }


    // IEnumerator P2Win(){
    //     yield return new WaitForSeconds(4.5f);
    //     SceneManager.LoadScene("P1Win");
    // }
    // IEnumerator P1Win(){
    //     yield return new WaitForSeconds(4.5f);
    //     SceneManager.LoadScene("P2Win");
    // }

    
    // void WinScene(){
    //     if (GameManager.player1hp <= 0)
    //     {
    //         StartCoroutine(WinSceneDelay());
    //     }

    //     else if (GameManager.player2hp <= 0)
    //     {
    //         StartCoroutine(WinSceneDelay());
    //     }
    // }
}
