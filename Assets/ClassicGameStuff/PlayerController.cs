using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax;
}

public class PlayerController : MonoBehaviour {

    public float speed;
    public Boundary boundary;


    void Update()
    {
     
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        
        Vector3 movement = new Vector3(Input.acceleration.x, 0.0f, 0.0f);
        GetComponent<Rigidbody>().velocity = movement * speed;
        
        GetComponent<Rigidbody>().position = new Vector3
            (
                Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
                GetComponent<Rigidbody>().position.y, 
                GetComponent<Rigidbody>().position.z
            );     
    }
}
