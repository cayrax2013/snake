using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    private int _currentScore = 0;

    private void Start()
    {
        PlayerPrefs.SetInt("currentScore", _currentScore);
    }

    public void Add()
    {
        _currentScore++;

        PlayerPrefs.SetInt("currentScore", _currentScore);

        if (PlayerPrefs.GetInt("highScore") < _currentScore)
            PlayerPrefs.SetInt("highScore", _currentScore);
    }
}
