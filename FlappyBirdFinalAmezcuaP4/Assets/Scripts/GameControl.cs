using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public GameObject gameOverText;      //text that displays game over
    public bool gameOver = false;        //gameOver wont load in at the start of the gmae
    private int score = 0;               //score is 0 when game starts
    public static GameControl instance;
    public float scrollSpeed = -1.5f;    // sets speed for objects to scroll at
    public Text scoreText;               // gets UI text ready

    //on startup, if there is no game control, set it to this, if there isnt then destroy self
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    //if game over is true AND flap is pressed, reload the current scene
    void Update()
    {
        if (gameOver == true && (Input.GetKeyDown(KeyCode.Space)))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
;
    }

    public void GundamScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + score.ToString();

    }


    // if "Gundam" script sends crash signal, make game over text visible and set game over to true
    public void GundamCrash()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }


}
