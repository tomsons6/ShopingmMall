using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateProduct : MonoBehaviour
{
    [SerializeField]
    int RotationSpeed = 2;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 50*Time.deltaTime / RotationSpeed, 20 * Time.deltaTime / RotationSpeed);
    }
}
