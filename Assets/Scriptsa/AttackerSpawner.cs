using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float MaxSpawnDelay = 5f;
    [SerializeField] Attack[] attackerPrefabArray;
    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, MaxSpawnDelay));
            SpawnAttacker();
        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    private void SpawnAttacker()
    {
        var attackerIndex = Random.Range(0, attackerPrefabArray.Length);
        Spawn(attackerPrefabArray[attackerIndex]);
    }

    private void Spawn(Attack myAttacker)
    {
        Attack newAttacker = Instantiate(myAttacker, transform.position, transform.rotation) as Attack;
        newAttacker.transform.parent = transform;
    }

}