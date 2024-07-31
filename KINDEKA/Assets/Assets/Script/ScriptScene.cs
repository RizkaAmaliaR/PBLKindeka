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

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ToSceneMalikRoom()
    {
        SceneManager.LoadScene("DialogMalikRoom");
    }
    public void ToSceneDialogDuniaWonderlik()
    {
        SceneManager.LoadScene("DialoginDuniaWondelik");
    }
    public void ToSceneTransitionLvl2()
    {
        SceneManager.LoadScene("TransitionToLvl2");
    }
    public void ToSceneLvl1()
    {
        SceneManager.LoadScene("Lvl1");
    }
    public void ToSceneLvl2()
    {
        SceneManager.LoadScene("Lvl2");
    }
}
