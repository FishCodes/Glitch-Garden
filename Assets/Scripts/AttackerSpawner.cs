using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour {

    [SerializeField] Attacker[] attackerPrefabs;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    bool spawn = true;

	IEnumerator Start () {
		while (spawn)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    private void SpawnAttacker()
    {
        Attacker selectedAttacker = attackerPrefabs[UnityEngine.Random.Range(0, attackerPrefabs.Length)];
        Spawn(selectedAttacker);
    }

    private void Spawn(Attacker selectedAttacker)
    {
        Attacker newAttacker = Instantiate(selectedAttacker, transform.position, transform.rotation)as Attacker;
        newAttacker.transform.parent = transform;
    }


}
