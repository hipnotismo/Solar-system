using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundPoint : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private GameObject pivotObject;

    void Update()
    {
        transform.RotateAround(pivotObject.transform.position,new Vector3(0,1,0), rotationSpeed * Time.deltaTime);
    }
}
