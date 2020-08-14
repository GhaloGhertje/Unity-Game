using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownController : MonoBehaviour
{
    public Rigidbody2D rbBall;
    public Rigidbody2D rbBlue;
    public Rigidbody2D rbGreen;

    public int CountDownTime;
    public Text CountDownDisplay;

    private void Start()
    {
        StartCoroutine(CountDownToStart());
        rbBall.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        rbBlue.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        rbGreen.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
    }

    IEnumerator CountDownToStart()
    {
        while (CountDownTime > 0)
        {
            CountDownDisplay.text = CountDownTime.ToString();

            yield return new WaitForSeconds(1f);

            CountDownTime--;
        }

        rbBall.constraints = RigidbodyConstraints2D.None;
        rbBlue.constraints = RigidbodyConstraints2D.None;
        rbGreen.constraints = RigidbodyConstraints2D.None;

        CountDownDisplay.text = "GO";

        //GameController.instance.BeginGame();

        yield return new WaitForSeconds(1f);

        CountDownDisplay.gameObject.SetActive(false);
    }
}
