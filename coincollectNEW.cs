using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class coincollect2 : MonoBehaviour
{
    public int token = 0;
    public TextMeshProUGUI tokenText;

    public Image textbox;
    public TextMeshProUGUI funfact1;
    public TextMeshProUGUI funfact2;
    public TextMeshProUGUI funfact3;
    public newplayermovement playerMovement;
    public mouseinput mouseMovement;

    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "token")
        {
            playerMovement.enabled = false;
            mouseMovement.enabled = false;
            token++;
            tokenText.text = "Token Collected: " + token.ToString() + "/3";
            Debug.Log(token);
            Destroy(other.gameObject);
            if(token == 1){
                funfact1.gameObject.SetActive(true);
                textbox.gameObject.SetActive(true);
            } else if(token == 2){
                funfact2.gameObject.SetActive(true);
                textbox.gameObject.SetActive(true);
            } else if(token == 3){

                funfact3.gameObject.SetActive(true);
                textbox.gameObject.SetActive(true);
            }
        }
    }

    void Update()
    {
        // Check for Enter key press
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Enable player and mouse movement
            playerMovement.enabled = true;
            mouseMovement.enabled = true;

            // Hide fun fact text
            funfact1.gameObject.SetActive(false);
            funfact2.gameObject.SetActive(false);
            funfact3.gameObject.SetActive(false);
            textbox.gameObject.SetActive(false);
        }
        // if(token == 3){

        // }
    }

    private void Start(){
        funfact1.gameObject.SetActive(false);
        funfact2.gameObject.SetActive(false);
        funfact3.gameObject.SetActive(false);
        textbox.gameObject.SetActive(false);
    }
}