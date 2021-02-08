using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaStarRay : MonoBehaviour
{
    private Ray ray;
    public RaycastHit hit;
    private int frame = 0;
    public int rebounds;
    // Start is called before the first frame update
    void Start()
    {
        rebounds = 50000;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = new Ray(transform.position, transform.forward);
            Physics.Raycast(ray.origin, ray.direction*100, out hit);
           // Debug.DrawRay(ray.origin,transform.forward*100);
        }

    }
    public void CreateNewRay()
    {
        ray = new Ray(hit.point, Vector3.Reflect(ray.direction, hit.normal));
    }
}