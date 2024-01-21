using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public SoundEfectPlayer SoundEfectPlayer;
    public float delayScene;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreAdd)
    {
        playerScore = playerScore + scoreAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        StartCoroutine(DelayRestart(delayScene));
        
    }

    public void gameOver()
    {
        SoundEfectPlayer.GameOverSound();
        gameOverScreen.SetActive(true);
    }

    public void GoBackToMenu()
    {
        StartCoroutine(DelayMenu(delayScene));
 
    }


    IEnumerator DelayRestart(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator DelayMenu(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(0);
    }

}
