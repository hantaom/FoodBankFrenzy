using UnityEngine;
using System.Collections;

public class FoodObjectCaught : MonoBehaviour {


    //private FrenzyGameController gameController;

    private ArcadeGameController gameController;


    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {

            //gameController = gameControllerObject.GetComponent<FrenzyGameController>();

            gameController = gameControllerObject.GetComponent<ArcadeGameController>();

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
            else if (gameObject.tag == "Time")
            {
                gameController.addTime();
            }
            else if (gameObject.tag != "Boundary") gameController.collectOther();

            Destroy(gameObject);
        }
        
    }
}
