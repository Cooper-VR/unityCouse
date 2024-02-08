using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// INHERITANCE
public class BulletHit : ObjectHit 
{
    // ABSTRACTION
    public override void OnHit(string tag)
    {
        if (tag == "Rock")
        {
            Destroy(gameObject);
        }
    }
}
