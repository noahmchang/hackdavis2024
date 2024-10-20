using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapclick : MonoBehaviour
{
    public void gotoMU(){
        SceneManager.LoadScene("mu");
    }

    public void gotoLecture(){
        SceneManager.LoadScene("lecturehall");
    }
    public void gotoLibrary(){
        SceneManager.LoadScene("library");
    }
}
