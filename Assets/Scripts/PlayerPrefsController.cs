using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour {

    const string MASTER_VOLUME_KEY = "master volume";
    const string DIFFICULTY_KEY = "difficulty";

    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;

    const float MIN_DIFFICULTY = 0f;
    const float MAX_DIFFICULTY = 5f;

    public static void SetMasterVolume(float volume)
    {
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master volume is out of range");
        }
    }

    public static float GetMasterVolume(float defaultValue)
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY, defaultValue);
    }

    public static void SetDifficulty(float diff)
    {
        if (diff >= MIN_DIFFICULTY && diff <= MAX_DIFFICULTY)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, diff);
        }
        else
        {
            Debug.Log("Difficulty setting is not in range");
        }
    }

    public static float GetDifficulty(float defaultValue)
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY, defaultValue);
    }
}
