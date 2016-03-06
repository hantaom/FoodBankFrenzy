using UnityEngine;
using System.Collections;

public class FoodObjectCaught : MonoBehaviour {

<<<<<<< HEAD
    private FrenzyGameController gameController;
=======
    private ArcadeGameController gameController;
>>>>>>> 78913a9ff770a6be91c5248bf75b35086822c3e1

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
<<<<<<< HEAD
            gameController = gameControllerObject.GetComponent<FrenzyGameController>();
=======
            gameController = gameControllerObject.GetComponent<ArcadeGameController>();
>>>>>>> 78913a9ff770a6be91c5248bf75b35086822c3e1
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
