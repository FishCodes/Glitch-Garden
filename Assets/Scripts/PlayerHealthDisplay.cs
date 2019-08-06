using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthDisplay : MonoBehaviour {

    [SerializeField] int hitPoints = 5;
    [SerializeField] int damage = 1;
    Text healthText;

    private void Start()
    {
        healthText = GetComponent<Text>();
        UpdateDisplay();
    }

    public void LoseHitPoint()
    {
        hitPoints -= damage;
        UpdateDisplay();

        if (hitPoints <= 0)
        {
            FindObjectOfType<LevelLoader>().LoadYouLose();
        }
    }

    private void UpdateDisplay()
    {
        healthText.text = hitPoints.ToString();
    }
}
