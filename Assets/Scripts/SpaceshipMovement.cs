using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 5f;
    [SerializeField] GameObject pivotObject;

    void Update()
    {
        transform.RotateAround(pivotObject.transform.position, new Vector3(0, 0, -1), Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
    }
}
