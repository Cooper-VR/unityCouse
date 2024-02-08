using UnityEngine;

public abstract class ObjectHit : MonoBehaviour
{
    // ABSTRACTION
    public abstract void OnHit(string tag);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnHit(collision.gameObject.tag);
    }
}
