using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public GameObject playAgainPopUpUI;
    
    void Start()
    {
        StartCoroutine(DelayPopUp());
    }

    public void PlayAgainPopUp()
    {
        playAgainPopUpUI.SetActive(true);
    }

    public void PlayAgainButton()
    {
        GameManager.Destroy(this);
        SceneManager.LoadScene("CharacterSelect");
    }

    public void MenuButton()
    {
        GameManager.Destroy(this);
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitButton()
    {
        GameManager.Destroy(gameObject);
        Application.Quit();
    }

    IEnumerator DelayPopUp(){
        yield return new WaitForSeconds(5);      
        PlayAgainPopUp();
        yield return new WaitForSeconds(4);
    }
}
