using UnityEngine;
using System.Collections;

public class FoodObjectCaught : MonoBehaviour {

    private GameController gameController;
    
    bool bounce = false;
    int upTime = 0;

    float up = (float)0.05;
    float forward = (float)0.01;


    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
    }

    void Update()
    {
        if (bounce)
        {
            if (upTime < 50)
            {
                transform.localScale += new Vector3(-0.01F, -0.01F, -0.01F);
            }
            else
            {
                up = up - 0.005F;
            }


            transform.position = new Vector3(transform.position.x, transform.position.y - up, transform.position.z);

            
            up = up - 0.003F;
            if (up < 0)
            {
                up = 0;
            }

            upTime++;
        }




    }
    void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.tag == "Box")
        {

            if (gameObject.tag == gameController.getDesiredCategory())
            {
               
                gameController.collectDesired();
            }
            else if (gameObject.tag == "Junk")
            {
                gameController.collectJunk();
            }
            else if (gameObject.tag != "Boundary") gameController.collectOther();


            bounce = true;
            //Destroy(gameObject);
            
        }

    }
}
