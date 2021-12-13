using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    //Rotation By Axis
    [Tooltip("Rotation Speed by axis")]
    public Vector3 rotateSpeed = new Vector3(0, 1, 0);

    //Uses DeltaTime bool
    [Tooltip("If the rotation uses the DeltaTime")]
    [SerializeField]
    private bool usesDeltaTime;

    void Update()
    {
        //The Rotation if uses DeltaTime
        if (usesDeltaTime)
        {
            transform.Rotate(rotateSpeed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        //The Rotation if doesn't use DeltaTime
       if (!usesDeltaTime)
        {
            transform.Rotate(rotateSpeed);
        }
    }
}