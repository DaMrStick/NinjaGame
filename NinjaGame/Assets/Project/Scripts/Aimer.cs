using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aimer : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        LookAtMouse();

    }
    private void LookAtMouse()
    {
        Vector3 MousePosition=Input.mousePosition;
        MousePosition = Camera.main.ScreenToWorldPoint(new Vector3(MousePosition.x,MousePosition.y,-400));
        Vector2 direction = new Vector2
        (
            MousePosition.x - transform.position.x,
            MousePosition.y - transform.position.y
        );
        transform.forward = -1 * direction;//direction*-1;
        //transform.rotation = Quaternion.Euler(transform.rotation.y,0f,transform.rotation.z);
    }
}
