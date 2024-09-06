using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpinner : MonoBehaviour
{
    public Vector3 rotationVector;
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rotationVector* Time.deltaTime);
    }
}

