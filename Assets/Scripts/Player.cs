using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ePlayer
{
    Left,
    Right
}
public class Player : MonoBehaviour
{
    public float speed = 12f;
    public ePlayer player;

    void Update()
    {
        float inputSpeed = 0f;
        if (player == ePlayer.Left)
        {
            inputSpeed = Input.GetAxisRaw("Vertical");
        }
        else if (player == ePlayer.Right)
        {
            inputSpeed = Input.GetAxisRaw("Vertical2");
        }
        transform.position += new Vector3(0f, inputSpeed * speed * Time.deltaTime, 0f);
    }
}
