

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja : MonoBehaviour
{
    public GameObject NinjaStarPrfab;
    public GameObject TopOfAimer;
    public GameObject Aimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject ninPrefab = Instantiate(NinjaStarPrfab);
            Transform nintran = ninPrefab.transform;
            ninPrefab.transform.position=TopOfAimer.GetComponent<Transform>().position;
            ninPrefab.transform.forward = Aimer.transform.forward;
            ninPrefab.transform.Rotate(0f,90f,0f);
        }
        
        transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime,0f,0f);
    }
}