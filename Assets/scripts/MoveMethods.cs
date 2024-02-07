using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMethods : MonoBehaviour
{
    public obectType type;
    private Rigidbody2D rb;
    private float speed = 900f;

    public enum obectType
    {
        Player,
        Object
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move()
    {

    }
    public void Move(Vector2 MoveVector)
    {
        if (rb.velocity.magnitude < 25)
        rb.AddForce(MoveVector * speed * Time.deltaTime);
    }

    private void Update()
    {
        Vector2 moveVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (type == obectType.Player)
        {
            Move(moveVector);
        }
        else
        {
            Move();
        }
    }
}
