using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class SnakeTailHandler : MonoBehaviour
{
    [SerializeField] private List<Transform> _tails;
    [SerializeField] private float _distanceBetweenBones = 1f;
    [SerializeField] private GameObject _bone;
    [SerializeField] private Transform _snake;

    private float _speed;

    private void Start()
    {
        _speed = PlayerPrefs.GetFloat("speedSnake");
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, _tails[0].transform.position) > _distanceBetweenBones)
            _tails[0].transform.position = Vector3.MoveTowards(_tails[0].transform.position, transform.position, _speed * Time.deltaTime);

        for (int i = 1; i < _tails.Count; i++)
        {
            var previousTail = _tails[i - 1];

            if (Vector3.Distance(previousTail.position, _tails[i].position) > _distanceBetweenBones)
                _tails[i].position = Vector3.MoveTowards(_tails[i].position, previousTail.position, _speed * Time.deltaTime);
        }
    }

    public void AddTail()
    {
        var newBone = Instantiate(_bone, _snake.position, Quaternion.identity);
        _tails.Add(newBone.transform);
    }

    public void StopMovement()
    {
        _speed = PlayerPrefs.GetFloat("speedSnake");
    }
}
