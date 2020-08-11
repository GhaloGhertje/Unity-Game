using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Player;
    public GameObject Effect;
    private bool isRespawning;
    private Vector3 respawnPoint;

    void Start()
    {
        respawnPoint = Player.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            {
                GameObject e = Instantiate(Effect) as GameObject;
                respawn(); //functie
            }
        }
    }

    public void respawn() //functie die uitgevoerd wordt
    {
        Player.transform.position = respawnPoint;
    }
}
