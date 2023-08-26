using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAnalyzer : MonoBehaviour
{
    public Vector3 rotationVector;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Head")
        {
            other.gameObject.transform.position = transform.position;
            other.gameObject.transform.Rotate(rotationVector * Time.deltaTime);
        }
    }
}
