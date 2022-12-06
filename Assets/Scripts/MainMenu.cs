using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
        PauseMenu.GameIsPause = false;
    }

    public void QuitGame(){
        Debug.Log("Saiu.");
        Application.Quit();
    }
    public void GameOver(){
        SceneManager.LoadScene("SampleScene");
    }
}
