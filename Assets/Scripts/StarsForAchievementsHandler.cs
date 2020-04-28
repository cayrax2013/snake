using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsForAchievementsHandler : MonoBehaviour
{
    [SerializeField] Image[] _stars;
    [SerializeField] private Sprite _filledStar;
    [SerializeField] private Sprite _emptyStar;

    private void Start()
    {
        DisplayAchievemetns();
    }

    private void DisplayAchievemetns()
    {
        var currentScore = PlayerPrefs.GetInt("currentScore");

        if (currentScore < 5)
        {
            //Молодец, почти не бот
        }
        else if (currentScore > 50)
        {
            for (int i = 0; i < _stars.Length; i++)
            {
                _stars[i].sprite = _filledStar;
            }
        }
        else if (currentScore > 20 && currentScore < 50)
        {
            _stars[0].sprite = _filledStar;
            _stars[1].sprite = _filledStar;
        }
        else
            _stars[0].sprite = _filledStar;
    }
}
