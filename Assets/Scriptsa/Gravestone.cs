using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravestone : MonoBehaviour {
  
  private void OnTriggerEnter2D(Collider2D otherCollider)
    {
    Attacker attacker = otherCollider.GetComponent<Attack>();
    if(attacker)
    {
      // do a backflip
    } 
  
}
