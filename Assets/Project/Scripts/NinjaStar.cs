using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaStar : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once er frame
    void Update()
    {
        transform.position += transform.right*-1/2;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hi");
        transform.forward = Vector3.Reflect(transform.forward, collision.transform.position.normalized);
    }
}
