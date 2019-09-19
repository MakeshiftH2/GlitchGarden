using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
  
  [Range (0f, 5f)]
  float currentSpeed = 1f;
  GameObject currentTarget;
  
  void Update ()
  {
    transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
  }
  
  public void SetMovementSpeed(float speed)
  {
    currentSpeed = speed;
  }
  
  public void Attacked(GameObject target)
  {
    GetComponent<Animator>().SetBool("isAttacking", true);
    currentTarget = target;
  }
  
}
