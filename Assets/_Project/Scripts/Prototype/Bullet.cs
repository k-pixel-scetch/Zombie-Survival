using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int _damage = 25;
    private float _speed = 5.0f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        { 
            other.GetComponent<Health>().TakeDamage(_damage); 
        }

        DestroyObject();
    }

    private void Movement(Vector2 direction) 
    {
        StartCoroutine(AutoDestroy());
    }

    private IEnumerator AutoDestroy() 
    { 
        yield return new WaitForSeconds(4);

        DestroyObject();
    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }
}
