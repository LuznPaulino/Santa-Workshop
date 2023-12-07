using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransition : MonoBehaviour
{
    public void NextScene(int sceneNumber)
    {
        switch (sceneNumber)
        {
            case 1:
                SceneManager.LoadScene("Main Menu");
                break;
            case 2:
                SceneManager.LoadScene("Start Page");
                break;
            case 3:
                SceneManager.LoadScene("The Game");
                break;
            default:
                Application.Quit();
                break;
        }
    }
}
