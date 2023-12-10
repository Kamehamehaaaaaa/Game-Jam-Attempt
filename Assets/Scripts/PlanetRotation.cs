using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 25f;

    void Update()
    {
        // transform.Rotate(0, 0, Mathf.Abs(Input.GetAxis("Horizontal")) * rotationSpeed * Time.deltaTime, Space.Self);
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
