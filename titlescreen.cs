using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class mainmenutest : MonoBehaviour
{
    public Image textbox;
    public TextMeshProUGUI credittext;
    public void playGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void gotogame(){
        SceneManager.LoadScene("welcomescreen");
    }
    public void credits(){
        textbox.gameObject.SetActive(true);
        credittext.gameObject.SetActive(true);
    }
    public void quit(){
        Application.Quit();
    }
    void Start(){
        textbox.gameObject.SetActive(false);
        credittext.gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            textbox.gameObject.SetActive(false);
            credittext.gameObject.SetActive(false);
        }
    }
}
