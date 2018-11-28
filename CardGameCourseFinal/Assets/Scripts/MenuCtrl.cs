using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCtrl : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        PlayerManagement.resetLevel();
        PlayerManagement.increaseLevel();
        PlayerManagement.iniDeck();
        SceneManager.LoadScene(sceneName);


    }
    public void Fighter() {
        PlayerManagement.ChooseFighter();
    }
    public void ASSASSIN()
    {
        PlayerManagement.ChooseASSASSIN();
    }
    public void SAGE()
    {
        PlayerManagement.ChooseSAGE();
    }
}