using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour {

    [SerializeField] Defender defenderPrefab;
    Color darkColor;

    private void Start()
    {
        darkColor = GetComponent<SpriteRenderer>().color;
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = darkColor;
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<SpawnDefender>().SetSelectedDefender(defenderPrefab);
    }
}
