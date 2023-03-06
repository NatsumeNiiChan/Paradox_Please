using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 20.0f;

    public float Horizontal;
    public float Vertical;

    private Rigidbody2D playerBody;

    private void Awake()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        playerBody.velocity = new Vector2(Horizontal * Speed, Vertical * Speed);
    }
}
