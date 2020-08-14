using System.Collections;               //hoef je niet te weten (maar let er wel op als je de code van iemand anders (deels) gebruikt)
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Score : MonoBehaviour
{                                       //public koppelt 
    public Rigidbody2D rb;              //hierin kan je de mechanics van het gewicht en weerstand in zetten in unity (kom je nog wel achter)

    static public int score;            //int is een variabele voor een heel getal (zonder decimalen (met decimalen gebruik je meestal float))
    public Text BlueScore;              //staat in unity (hierin kan je de text van de score inslepen, zodat je de score ziet)

    public GameObject Blue;             //hiermee kan je het bal object in unity koppelen aan het script
    public Vector3 StartPointBlue;      //hiermee kan je in unity de locatie aangeven, vector3 kan namelijk 3 nummers "onthouden" (ook wel x, y en z)
    public GameObject Green;
    public Vector3 StartPointGreen;
    public GameObject Ball;
    public Vector3 StartPointBall;

    void OnTriggerEnter2D(Collider2D other) //een collider met het goal en een object
    {
        if (other.gameObject.name == "Ball") //zorgt ervoor dat een bal alleen het goal kan veroorzaken
        {
            AddScore();
            Blue.transform.position = StartPointBlue;   //respawns na goal
            Green.transform.position = StartPointGreen;
            rb.velocity = new Vector3(0, 0, 0);         //zodat de bal de snelheid en richting niet behoudt na de respawn
            Ball.transform.position = StartPointBall;
        }
    }
    void AddScore()
    {
        score++;                               //herkenbaar van javascript
        BlueScore.text = score.ToString();     //BlueScore.text is de text van de blauwe kant waarop de score wordt weergeven
                                               //score is de variabele score die veranderd als je een punt scoort. Als de score 5 is wordt het getal 5 laten zien in die tekst
                                               //ToString is letterlijk vertaald naar woorden of naar tekst

        if (score == 10)                       //als blauw 10 punten is komt de WinningScene
        {
            WinningScene();                    //roept functie op
        }
    }

    void WinningScene() //een soort van animatie of iets anders dat je laat weten dat je gewonnen hebt
    {
        BlueScore.text = "Champion".ToString(); //bij de score komt "Champion" te staan als je gewonnen hebt
        //leuke animatie of iets
        PauseMenu(); //is een functie oproep
    }

    void PauseMenu() //dit is een functie van het menu als het potje is beïndigt
    {
        //moet nog wat invullen
    }
}
