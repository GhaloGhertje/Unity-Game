using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    public int score;
    public Text GreenScore;
    public GameObject Ball;


    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        AddScore();
    }
    void AddScore()
    {
        score++;
        GreenScore.text = score.ToString();
    }

    void BallRespawn()
    {
        GameObject a = Instantiate(Ball) as GameObject;
    }
}
