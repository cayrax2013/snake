using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeAudioHandler : MonoBehaviour
{
    [SerializeField] private AudioSource _eatFood;

    public void TurnOnSoundEatAple()
    {
        _eatFood.Play();
    }
}
