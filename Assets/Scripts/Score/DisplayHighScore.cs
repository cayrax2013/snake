using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHighScore : MonoBehaviour
{
    [SerializeField] private Text _display;
    [SerializeField] private string _pattern = "High Score: {0}";

    private void Start()
    {
        Display();
    }

    private void Display()
    {
        int highScore = PlayerPrefs.GetInt("highScore");
        _display.text = string.Format(_pattern, highScore);
    }
}
