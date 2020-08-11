using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text BlueScore;
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
        BlueScore.text = score.ToString();
    }

    void BallRespawn()
    {
        GameObject a = Instantiate(Ball) as GameObject;
    }
}
