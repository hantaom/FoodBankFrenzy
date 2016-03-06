using UnityEngine;
using System.Collections;

public class FoodObjectCaught : MonoBehaviour {

   void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {/*
        if (other.tag == "Boundary")
        {
            Destroy(other.gameObject);
        }*/
        
        if (other.tag == "Box")
        {
            Destroy(gameObject);
        }
        
    }
}
