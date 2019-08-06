using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [Range(0f,10f)]
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] int damage = 100;

    void Update () {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Health>() && other.GetComponent<Attacker>())
        {
            other.GetComponent<Health>().DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
