﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefsController.SetMasterVolume(0.4f);
        PlayerPrefsController.GetMasterVolume();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}