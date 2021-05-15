using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsManager : MonoBehaviour
{
    GameManager gameManager;

    void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    public void Resume()
    {
        gameManager.theGameIsPaused = false;
        gameManager.Resume();
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
