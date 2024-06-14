using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptScene : MonoBehaviour
{
    public void BtnPlay()
    {
        SceneManager.LoadScene("IntroCutScene");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is Closed");
    }
}
