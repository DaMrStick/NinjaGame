using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja : MonoBehaviour
{
    public GameObject NinjaStarPrfab;
    public GameObject TopOfAimer;
    public GameObject Aimer;
    public GameObject NinjaStars;
    public Rigidbody2D rb;
    public float speed = 1;
    private bool IsJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //the moving
        Move("d", speed, transform.right);
        Move("a", speed, transform.right*-1);
        // the shooting
        if (Input.GetMouseButtonDown(0))
        {
           shoot();
        }
        
    }
    
    void FixedUpdate()
    {
       /* if (rb.velocity == new Vector2(0,0))
        {
            IsJumping = false;
        }*/
        if (Input.GetKeyDown("w") && IsJumping == true)
        {
            rb.AddForce(transform.up*speed *10);
            IsJumping = true;
        }
    }

    void Move(string key, float speed, Vector3 direction)
    {
        if (Input.GetKey(key))
        {
            rb.MovePosition(transform.position + direction/32 * speed);
        }
        
    }
    void shoot()
    {
        GameObject ninPrefab = Instantiate(NinjaStarPrfab);
        Transform nintran = ninPrefab.transform;
        ninPrefab.transform.position=TopOfAimer.GetComponent<Transform>().position;
        ninPrefab.transform.forward = Aimer.transform.forward;
        ninPrefab.transform.Rotate(0f,90f,0f);
        ninPrefab.transform.SetParent(NinjaStars.transform);
    }
    
}