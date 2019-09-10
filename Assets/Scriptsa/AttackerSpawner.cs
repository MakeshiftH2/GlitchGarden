using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour {
  
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float MaxSpawnDelay = 5f;
    [SerializeField] Attack attackerPrefab;
    bool spawn = true;
    
    IEnumerator Start() {
      while(spawn)
      {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, MaxSpawnDelay));
        SpawnAttacker();
      }
    }
    
    private void SpawnAttacker()
    {
     Attack newAttacker = Instantiate(attackerPrefab, transform.position, transform.rotation) as Attack;
      newAttacker.transform.parent = transform;
    }
    

}
