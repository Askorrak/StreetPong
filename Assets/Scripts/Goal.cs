using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayer1Goal)
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();              
            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
        }
    }
    
}