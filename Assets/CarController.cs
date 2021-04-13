using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class CarController : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float x = CrossPlatformInputManager.GetAxis("Horizontal")*10;
        float y = CrossPlatformInputManager.GetAxis("Vertical")*1;

        Vector3 movement = new Vector3(x, 0, y);

        rb.velocity = movement * 4f;

        if( x!= 0 && y!=0) {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x,y) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }

        

         
    }
}
