using System;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    //add variables to objects from hierarchy
    private int score;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public Player player;

    private void Awake()
    {
        Application.targetFrameRate = 120;

        Pause(); //stop game to wait for player to press play
    }
    [Obsolete]//Attribute
    public void Play() 
    {
        score = 0;
        scoreText.text = score.ToString();  //reset score at the start of a game

        playButton.SetActive(false); //hide buttons
        gameOver.SetActive(false);
        Time.timeScale = 1f; //unpause environment
        player.enabled = true;
        UnPause();

        Pipes[] pipes = FindObjectsOfType<Pipes>();  //to reset game

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
        
    }

 
    public void UnPause()  //unfreeze game
    {
        Time.timeScale = 1f;
        player.enabled = true;
    }

    public void Pause() //freeze game
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver() //stop game at game over 
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();

    }
    public void IncreaseScore() //increase score on screen
    {
        score++;
        scoreText.text = score.ToString();

    }
    // first project but for future I'll learn scenes
}
