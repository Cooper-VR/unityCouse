using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectHit : MonoBehaviour
{
    public abstract void OnHit();

    private void OnCollisionEnter(Collision collision)
    {
        OnHit();
        Destroy(gameObject);
    }
}
