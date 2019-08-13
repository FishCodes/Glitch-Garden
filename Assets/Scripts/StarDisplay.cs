using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour {

    [SerializeField] int starsAtLowestDifficulty = 1000; //Star amount at lowest difficulty setting
    int stars;
    Text starText;
    [Range(1,5)][SerializeField] int difficulty = 3;


	void Start () {
        difficulty = (int)PlayerPrefsController.GetDifficulty(difficulty);
        stars = starsAtLowestDifficulty / difficulty;
        starText = GetComponent<Text>();
        UpdateDisplay();
	}
	
    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public void SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
    }
}
