using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class column : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;
    }
}
