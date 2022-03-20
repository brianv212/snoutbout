using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    public static bool gamePaused = false;

    public GameObject pauseMenuUI;

    public string sLevelToLoad;
    public string menu = "Menu";

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (gamePaused)
            {
                Resume();
            }
            else {
                DoPause();
            }
        }
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void DoPause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }

    public void RestartLevel() {
        Resume();
        SceneManager.LoadScene(sLevelToLoad);
    }

    public void GoToMenu() {
        Resume();
        SceneManager.LoadScene(menu);
    }
}
