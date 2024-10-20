using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class welcomescene : MonoBehaviour
{
    // Start is called before the first frame update
    public textanimation textAnimation;
    public int entercounter = 0;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    void Start()
    {
        text2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            entercounter++;
            if(entercounter == 1){
                text1.gameObject.SetActive(false);
                text2.gameObject.SetActive(true);
                textAnimation.Start();
            } else if(entercounter == 2){
                SceneManager.LoadScene("worldmap1");
            }
        }
    }
}
