using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class CarController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 startPosition ;
    private Quaternion startRotation;
    private Vector3 movement;
    private float x;
    private float y; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        x = CrossPlatformInputManager.GetAxis("Horizontal");
        y = CrossPlatformInputManager.GetAxis("Vertical");
        
        movement = new Vector3(x, 0, y);

        rb.velocity = movement * 10f;

        if( x!= 0 && y!=0) {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x,y) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }
    }

    public void Reset() {
        print ("Resetting original position");

        //This just rotates the car. Figure out how to bring the car in the center
        transform.eulerAngles = new Vector3(x, 0.0f, y);
        //transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 10f));
    }
}

