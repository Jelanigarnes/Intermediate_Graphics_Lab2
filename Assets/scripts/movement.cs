using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Transform boxObject;
    public float moveSpeed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(boxObject.position, Vector3.up, moveSpeed);
        transform.LookAt(boxObject);
    }
}
