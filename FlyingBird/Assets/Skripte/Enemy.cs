using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject cloudPrefab;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bird ptica = collision.collider.GetComponent<Bird>();
        if (ptica != null)
        {
            Instantiate(cloudPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            return;
        }
        Enemy neprijatelj = collision.collider.GetComponent<Enemy>();
        if (neprijatelj != null)
        {
            return;
        }
        if (collision.contacts[0].normal.y<-0.5)
        {
            Instantiate(cloudPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
