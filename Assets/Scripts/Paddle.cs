using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float Speed;
    public Rigidbody Rigidbody;
    public Vector3 startPosition;

    private float movement;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (isPlayer1)
        {
            movement=Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement=Input.GetAxisRaw("Vertical2");
        }

        Rigidbody.velocity=new Vector2(Rigidbody.velocity.x, movement*Speed);
        
    }

    public void Reset()
    {
        Rigidbody.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
