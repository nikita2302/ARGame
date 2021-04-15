using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieWalk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      //  zombieAnimation.SetFloat("speed", 18.0f);
    }

    // Update is called once per frame
    void Update()
    {
        print("update empty");
    }

    public void DeleteZombie() {
        print ("Delete Zombie");
        Destroy(this);
    }
}
