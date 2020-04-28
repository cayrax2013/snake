using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] private string _pattern = "Score: {0}";
    [SerializeField] private Text _display;

    private void Start()
    {
        Display();
    }

    private void Display()
    {
        int currenScore = PlayerPrefs.GetInt("currentScore");
        _display.text = string.Format(_pattern, currenScore);
    }
}
