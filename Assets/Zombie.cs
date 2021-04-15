using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
   // Animator animator;

    // Start is called before the first frame update
    void Start()
    {
       // animator = GetComponent<Animator>();
       
       //var randomVector = new Vector3(Random.Range(0.5f, 1f), 0.5f, Random.Range(0.5f, 1f));
       //transform.position = randomVector;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveZombie() {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Car")
        {
            RemoveZombie();
        }
    }
}
