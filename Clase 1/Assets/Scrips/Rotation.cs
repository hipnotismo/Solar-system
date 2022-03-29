using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float rotation;
    void Update()
    {
        transform.Rotate(new Vector3(0, rotation,0) * Time.deltaTime);
    }
}
