using UnityEngine;
using System.Collections;

public class FrenzyFoodObjectCaught : MonoBehaviour {

    private FrenzyGameController gameController;

    bool drop = false;
    bool bounce = false;
    int upTime = 0;
    int scaleTime = 0;

    float up = (float)0.05;
    float forward = (float)0.1;




    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {

            //gameController = gameControllerObject.GetComponent<FrenzyGameController>();

                 gameController = gameControllerObject.GetComponent<FrenzyGameController>();


        }
    }

    void Update()
    {
        if (drop)
        {
            if (upTime < 50)
            {
                transform.localScale += new Vector3(-0.01F, -0.01F, -0.01F);
            }
            else
            {
                //up = up - 0.005F;
            }


            transform.position = new Vector3(transform.position.x, transform.position.y - up, transform.position.z);


            //up = up - 0.003F;
            if (up < 0)
            {
                up = 0;
            }

            upTime++;
        }

        if (bounce)
        {
            if (scaleTime < 60)
            {
                transform.localScale += new Vector3(-0.008F, -0.008F, -0.008F);

            }
            transform.position = new Vector3(transform.position.x, transform.position.y + forward, transform.position.z);
            forward -= 0.005F;
            if (forward < 0)
            {
                Destroy(gameObject);
            }

            scaleTime++;
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


            drop = true;
            //Destroy(gameObject);
            
        }

    }
}
