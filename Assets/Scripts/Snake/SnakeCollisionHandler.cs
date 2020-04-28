using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SnakeCollisionHandler : MonoBehaviour 
{
    [SerializeField] private UnityEvent _ateFood;
    [SerializeField] private UnityEvent _died;
    [SerializeField] private UnityEvent _cameAcrossToFence;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Food food))
        {
            Destroy(collision.gameObject);

            _ateFood?.Invoke();
        }

        if (collision.gameObject.tag == "Bone")
        {
            _died?.Invoke();
        }

        if (collision.gameObject.tag == "Wall")
        {
            _cameAcrossToFence?.Invoke();
            _died?.Invoke();
        }
    }
}
