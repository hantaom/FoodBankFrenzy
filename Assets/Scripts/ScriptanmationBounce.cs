using UnityEngine;
using System.Collections;

public class ScriptanmationBounce : MonoBehaviour {

    // Use this for initialization
    //animation for bad object
    int upTime = 0;
    
    float up = (float)0.05;
    float forward = (float)0.01;



    // Update is called once per frame
    void Update()
    {

        if (upTime < 50)
        {
            transform.localScale += new Vector3(-0.02F, -0.02F, -0.02F);
        }
        else
        {
            up = up - 0.005F;
        }


        transform.position = new Vector3(transform.position.x, transform.position.y + up, transform.position.z);
        
        up = up - 0.003F;
        
       
        upTime++;




    }
}
