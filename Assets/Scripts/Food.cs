using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(0, 5, 0);
    }
}
