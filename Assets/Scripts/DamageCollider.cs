using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour {

    PlayerHealthDisplay playerHealth;

    private void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealthDisplay>();
    }

    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        playerHealth.LoseHitPoint();
        if (otherObject.GetComponent<Attacker>() != null)
        {
            Destroy(otherObject.gameObject, 1f);
        }
    }
}
