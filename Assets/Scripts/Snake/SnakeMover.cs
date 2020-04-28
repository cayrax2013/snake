using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMover : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    private void Awake()
    {
        PlayerPrefs.SetFloat("speedSnake", _speed);
    }

    private void Update()
    {
        Move(transform.position + transform.forward * _speed * Time.deltaTime);
    }

    private void Move(Vector3 newPosition)
    {
        transform.position = newPosition;
    }

    public void Rotate(float angel)
    {
        transform.Rotate(0, angel, 0);
    }

    public void StopMovement()
    {
        _speed = 0;
        PlayerPrefs.SetFloat("speedSnake", _speed);
    }
}
