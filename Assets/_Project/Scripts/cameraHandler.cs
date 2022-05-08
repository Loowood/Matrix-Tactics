using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraHandler : MonoBehaviour
{
    public float rotationSpeed = 3f;
    public float displacementSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.eulerAngles += rotationSpeed * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0f);
        }
        if (Input.GetMouseButton(0))
        {
            transform.Translate(displacementSpeed * new Vector3(-Input.GetAxis("Mouse X"), -Input.GetAxis("Mouse Y"), 0));
        }
        if (Input.mouseScrollDelta.y > 0)
        {
            transform.Translate(displacementSpeed * new Vector3(0f, 0f, displacementSpeed));
        }
        if (Input.mouseScrollDelta.y < 0)
        {
            transform.Translate(displacementSpeed * new Vector3(0f, 0f, -displacementSpeed));
        }
    }
}
