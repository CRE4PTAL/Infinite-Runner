using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float worldScrollingSpeed = 0.2f;
    public Text scoreText;

    private float score;


    //pole w którym bêdziemy pamiêtaæ czy aktualnie trwa gra
    public bool inGame;

    //pole do podpiêcia przycisku reset
    public GameObject resetButton;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) { instance = this; }

        InitializeGame();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        // je¿eli aktualnie nie trwa gra nie wykonuj reszty metody
        if (!GameManager.instance.inGame) return;
        score += worldScrollingSpeed;
        UpdateOnScreenScore();
    }

    void UpdateOnScreenScore()
    {
        scoreText.text = score.ToString("0");
    }

    void InitializeGame()
    {
        inGame = true;
    }

    public void GameOver()
    {
        inGame = false;
        resetButton.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}