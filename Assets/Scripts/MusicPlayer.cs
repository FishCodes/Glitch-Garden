using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    AudioSource audioSource;
    [SerializeField] float initialVolume = 0.8f; // volume when no PlayerPrefs
    
    // Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsController.GetMasterVolume(initialVolume);
	}
	
	public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
