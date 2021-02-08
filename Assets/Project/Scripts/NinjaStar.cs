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
}
