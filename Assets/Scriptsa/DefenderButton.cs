using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour {
  
  [SerializeField] Defender defenderPrefab;
  
  // Create colliders for the sprites!
  
  private void Start()
  {
    LabelButtonWithCost();
  }
  
  private void LabelButtonWithCost()
  {
    Text costText = GetComponentInChildren<Text>();
    if (!costText)
    {
      Debug.Logerror(name + " has  no cost text, add some!");
    }
    else
    {
      costText.text = defenderPrefab.GetStarCost().ToString();
  
  public void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
      foreach(DefenderButton button in buttons)
      {
        button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
      }
      GetComponent<SpriteRenderer>().color = Color.white;
      FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
  }
