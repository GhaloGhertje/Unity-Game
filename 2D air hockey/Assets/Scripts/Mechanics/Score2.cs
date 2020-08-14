using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    public Rigidbody2D rb;

    public int score;
    public Text GreenScore;

    public GameObject Blue;
    public Vector3 StartPointBlue;
    public GameObject Green;
    public Vector3 StartPointGreen;
    public GameObject Ball;
    public Vector3 StartPointBall;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Ball") //zorgt ervoor dat alleen de bal er door heen kan
        {
            AddScore();
            Blue.transform.position = StartPointBlue;
            Green.transform.position = StartPointGreen;
            rb.velocity = new Vector3(0, 0, 0);
            Ball.transform.position = StartPointBall;


            //rb.velocity = new Vector2(0.0f, 0.0f);
        }
    }
    void AddScore()
    {
        score++;                               //herkenbaar van javascript
        GreenScore.text = score.ToString();     //GreenScore.text is de text van de blauwe kant waarop de score wordt weergeven
                                               // score is de variabele score die veranderd als je een punt scoort. Als de score 5 is wordt het getal 5 laten zien in die tekst
                                               //ToString is letterlijk vertaald naar woorden of naar tekst

        if (score == 10)
        {
            WinningScene();
        }
    }

    void WinningScene()
    {
        GreenScore.text = "Champion".ToString();
        //leuke animatie of iets
        PauseMenu();
    }

    void PauseMenu()
    {

    }
}
