using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class CountDownController : MonoBehaviour
{
    public Rigidbody2D rbBall;
    public Rigidbody2D rbBlue;
    public Rigidbody2D rbGreen;
    public Rigidbody2D rbYellow;
    public Rigidbody2D rbRed;

    public int CountDownTime;
    public Text CountDownDisplay;

    private bool Pause;

    void Start()
    {
        Pause = false;
        StartCoroutine(CountDownToStart());
        rbBall.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        rbBlue.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        rbGreen.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        rbYellow.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        rbRed.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
    }

    IEnumerator CountDownToStart()
    {
        while (CountDownTime > 0)
        {
            CountDownDisplay.text = CountDownTime.ToString();

            yield return new WaitForSeconds(1f);

            if (Pause == false)
            {
                CountDownTime--;
            }
        }

        rbBall.constraints = RigidbodyConstraints2D.None;
        rbBlue.constraints = RigidbodyConstraints2D.None;
        rbGreen.constraints = RigidbodyConstraints2D.None;
        rbYellow.constraints = RigidbodyConstraints2D.None;
        rbRed.constraints = RigidbodyConstraints2D.None;

        CountDownDisplay.text = "GO";
        
        yield return new WaitForSeconds(1f);


        if (Pause == false)
        {
          CountDownDisplay.gameObject.SetActive(false);
        }
    }
    public void PauseMenu()
    {
        Pause = true;
        rbBall.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        rbBlue.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        rbGreen.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        rbYellow.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        rbRed.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
    }

    public void Resume()
    {
        Pause = false;
        rbBall.constraints = RigidbodyConstraints2D.None;
        rbBlue.constraints = RigidbodyConstraints2D.None;
        rbGreen.constraints = RigidbodyConstraints2D.None;
        rbYellow.constraints = RigidbodyConstraints2D.None;
        rbRed.constraints = RigidbodyConstraints2D.None;

        StartCoroutine(myDelay());

        IEnumerator myDelay()
        {
            yield return new WaitForSeconds(0.5f);

            if (CountDownDisplay.text == "GO")
            {
                CountDownDisplay.gameObject.SetActive(false);
            }
        }
    }
}
