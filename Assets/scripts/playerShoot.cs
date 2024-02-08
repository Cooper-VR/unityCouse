using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{

    bool ready = true;
    public GameObject bulletPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ready)
        {
            ready = false;
            StartCoroutine(coroutine());
            Shoot();
        }
    }

    private void Shoot()
    {
        Debug.Log("fire");

        GameObject bullet = Instantiate(bulletPrefab, transform.position + transform.up * 2, transform.rotation, transform.parent);
        bullet.GetComponent<Rigidbody2D>().AddForce(transform.up * 7000);
    }


    IEnumerator coroutine()
    {
        yield return new WaitForSeconds(1);

        //done
        ready = true;
    }
}
