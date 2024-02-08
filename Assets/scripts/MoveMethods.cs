using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMethods : MonoBehaviour
{
    public obectType type;
    private Rigidbody2D rb;
    private float speed = 180000f;
    private float rotateSpeed = 175;

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
        transform.Rotate(new Vector3(0, 0, rotateSpeed * -Input.GetAxis("Horizontal") * Time.deltaTime));

        rb.velocity = Vector3.ClampMagnitude(rb.velocity, 25);

        rb.AddForce(MoveVector * speed * Time.deltaTime);
    }

    private void Update()
    {
        Vector2 moveVector = transform.up * Input.GetAxis("Vertical");

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
