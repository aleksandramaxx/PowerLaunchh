using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool GisPaused = false;
    public GameObject PauseMenu;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GisPaused)
            {
                Resumee();
            }
            else
            {
                Pausee();
            }
        }
    }
    public void Resumee()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GisPaused = false;
    }
    void Pausee()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GisPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void QuitGamee()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
