using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Score")]
    public int player1Score = 0;
    public int player2Score = 0; /* Note: If you merge the players scores in 1 line, the inspector will have some glitches, but you can do it anyway*/ 
    public TextMeshProUGUI player1ScoreText, player2ScoreText;

    [Header("Ball Initilizing")]
    public GameObject ball;
    public float SpawnBallDelay;

    [Header("Pause the game")]
    public bool theGameIsPaused;
    public GameObject pauseMenu;

    void Start()
    {
        SpawnBall();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            theGameIsPaused = !theGameIsPaused;
            if (theGameIsPaused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }


    public void StartNewRound(bool player1Won)
    {
        Invoke("SpawnBall", SpawnBallDelay);
        AddScore(player1Won);
        UpdateScoreText();
    }

    private void SpawnBall()
    {
        Instantiate(ball);
    }
    private void AddScore(bool forPlayer1)
    {
        if (forPlayer1)
        {
            player1Score++;
            return;
        }
        player2Score++;
    }
    private void UpdateScoreText()
    {
        player1ScoreText.text = player1Score.ToString();
        player2ScoreText.text = player2Score.ToString();
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
}