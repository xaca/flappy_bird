using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int lives = 3;
    public int score = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
        score += points;
        UIManager.instance.UpdateScore(score);
    }

    public void LoseLife()
    {
        lives--;
        UIManager.instance.UpdateLives(lives);
        if (lives <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
