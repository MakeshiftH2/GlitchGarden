using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsController : MonoBehaviour {
  
  [SerializeField] Slider volumeSlider;
  [SerializeField] float defaultVolume = 0.8f;
  
  void Start()
  {
    volumeSlider.value = PlayerPrefsController.GetMasterVolume();
  }
  
  void Update () {
    var musicPlayer = FindObjectOfType<MusicPlayer>();
    if (musicPLayer)
    {
      musicPlayer.SetVolume(volumeSlider.value);
    }
    
    else
    {
      Debug.LogWarning("NO Music Detected");
    }
  }
  
  public void SaveAndExit()
  {
    PlayerPrefsController.SetMasterVOlume(volumeSlider.value);
    FindObjectOfType<LevelLoader>().LoadMainMenu();
  }
  
  public void SetDefaults()
  {
    volumeSlider.value = defaultVOlume;
  }
  
}
