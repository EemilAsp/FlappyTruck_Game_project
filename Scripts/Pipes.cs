using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float Pipespeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += ((Vector3.left * Pipespeed) * Time.deltaTime);
    }
}
