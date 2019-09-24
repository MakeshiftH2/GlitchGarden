using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {
  
  [Tooltip("Our Level Timer in seconds")]
  [SerializeField] float levelTime = 10;
  
  void Update() {
    GetComponent<Slider>().value = Time.timeSinceLevelLoad/levelTime;
    
    bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);
    if (timerFinished)
    {
      Debug.Log("bitch");
    }
  }


}
