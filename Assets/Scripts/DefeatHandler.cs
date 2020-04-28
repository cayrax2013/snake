using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefeatHandler : MonoBehaviour
{
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private GameObject _leftButton;
    [SerializeField] private GameObject _rightButton;

    public void DisplayLosePanel()
    {
        _losePanel.SetActive(true);
        _leftButton.SetActive(false);
        _rightButton.SetActive(false);
    }
}
