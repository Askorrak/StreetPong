using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player1")]
    public GameObject Player1Paddle;
    public GameObject Player1Goal;

     [Header("Player2")]
    public GameObject Player2Paddle;
    public GameObject Player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;
    public GameObject GOAL;
    public GameObject GOAL2;

    private int Player1Score;
    private int Player2Score;

    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text=Player1Score.ToString();
        GOAL2.gameObject.SetActive(true);
        StartCoroutine(WaitFirst());
    }
    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text=Player2Score.ToString();
        GOAL.gameObject.SetActive(true);
        StartCoroutine(WaitFirst());
    }

    IEnumerator WaitFirst()
    {
        yield return new WaitForSeconds(3);
        GOAL.gameObject.SetActive(false);
        GOAL2.gameObject.SetActive(false);
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        Player1Paddle.GetComponent<Paddle>().Reset();
        Player2Paddle.GetComponent<Paddle>().Reset();
    }
}
