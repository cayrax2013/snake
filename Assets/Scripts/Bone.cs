using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class Bone : MonoBehaviour
{
    private SphereCollider _sphereCollider;
    private float _elapsedTime = 0f;

    private void Start()
    {
        _sphereCollider = GetComponent<SphereCollider>();
        _sphereCollider.enabled = false;
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= 1.5)
            _sphereCollider.enabled = true;
    }
}
