using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaStar : MonoBehaviour
{
    public RaycastHit hit;
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
        Debug.DrawRay(transform.position, Vector3.Reflect(transform.position,hit.normal)*100);
        transform.forward = Vector3.Reflect(transform.forward,hit.normal);
        transform.position += transform.right*-1/2;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        ShootRay(transform.right*-1);
    }
    public void ShootRay(Vector3 direction)
    {
        Physics.Raycast(transform.position, direction*1000, out hit);
        Debug.DrawRay(transform.position, Vector3.Reflect(transform.position,hit.normal)*100);
    }
}
