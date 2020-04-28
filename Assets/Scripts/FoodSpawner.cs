using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _food;

    public void Spawn()
    {
        Instantiate(_food, new Vector3(Random.Range(-17, 18), 0.5f, Random.Range(1.96f, 37.53f)), Quaternion.identity);
    }
}
