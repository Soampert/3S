using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    public TextMeshProUGUI scoreText;

    private int score;

    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void UpdateScore(int pointToAdd)
    {
        score += pointToAdd;
        scoreText.text = "Score: {score}";
    }
    /*
    public void GameOver()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true);
    }
    */

    // Update is called once per frame
    void Update()
    {

    }
}
