using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectHit : MonoBehaviour
{
    public abstract void OnHit();



    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnHit();

        Debug.Log("hit");

        Destroy(gameObject);
    }
}
