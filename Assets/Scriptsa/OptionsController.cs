using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsController : MonoBehaviour {
  
  [SerializeField] Slider volumeSlider;
  [SerializeField] Slider difficultySlider;
  [SerializeField] float defaultVolume = 0.8f;
  [SerializeField] float defaultDifficulty = 0;
  
  void Start()
  {
    volumeSlider.value = PlayerPrefsController.GetMasterVolume();
    difficultySlider.value = PlayerPrefsController.GetDifficulty();
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
    PlayerPrefsController.SetDIfficulty(DifficultySlider.value);
    FindObjectOfType<LevelLoader>().LoadMainMenu();
  }
  
  public void SetDefaults()
  {
    volumeSlider.value = defaultVOlume;
    difficultySlider.value = defaultDifficulty;
  }
  
}
