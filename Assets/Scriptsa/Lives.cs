using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : Monobehaviour {
  [SerializeField] int lives = 5;
  [SerializeField] int damage = 1;
  Text livesText;
   
   void Start() 
   {
     livesText = GetComponent<Text>();
     UpdateDisplay();
   }
   
   private void UpdateDisplay()
     {
       livesText.text = lives.ToString();
     }
   
   public voidtakeLife()
   {
     lives -= damage;
     UpdateDisplay();
     
     if (lives <= 0)
     {
       FindObjectOfType<LevelLoader>().LoadYouLose();
   }
}
