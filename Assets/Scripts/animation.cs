using UnityEngine;
using System.Collections;

public class animation : MonoBehaviour {
    //animation for good object
    //int upTime = 0;
    //int downTime = 0;
   // float up = (float)0.01;
    float down = (float)0.1;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale += new Vector3(-0.02F, -0.02F, -0.02F);
        
        
        transform.position = new Vector3(transform.position.x, transform.position.y - down, transform.position.z);
            
        
       

    }
}
