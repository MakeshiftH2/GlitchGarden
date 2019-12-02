using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    [SerializeField] int timeToWait = 3;
    int currentSceneIndex;
    float delayInSeconds = 2f;

    public void QuitGame()
    {
        Application.Quit();
    }

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Start Menu");
        Time.timeScale = 1;
    }

    public void LoadOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 2);
    }

    public void LoadYouLose()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void LoadTutoiral()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void LoadNextTutorial()
    {
        SceneManager.LoadScene("Tutorial 2");
    }

    public void LoadGameAgain()
    {
        SceneManager.LoadScene("Level 2");
    }

}