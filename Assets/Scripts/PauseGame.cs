using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel")) //press esc key
        {
            if(gamePaused == false)
            {
                Time.timeScale = 0; //freezing everything
                gamePaused = true;
                Cursor.visible = true;
                this.GetComponent<AudioSource>().Pause();
                pauseMenu.SetActive(true);
            }
            else
            {
                pauseMenu.SetActive(false);
                this.GetComponent<AudioSource>().UnPause();
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
            }
        }
    }

    public void UnpauseGame()
    {
        pauseMenu.SetActive(false);
        this.GetComponent<AudioSource>().UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void QuitLevel()
    {
        Time.timeScale = 1;
        GlobalLevel.levelNumber = 3;
        SceneManager.LoadScene(1);
    }
}
