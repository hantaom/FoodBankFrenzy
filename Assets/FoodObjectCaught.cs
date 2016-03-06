using UnityEngine;
using System.Collections;

public class FoodObjectCaught : MonoBehaviour {

    private GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
    }
    void OnTriggerEnter(Collider other)
    {   
        if (other.tag == "Box")
        {   

            if (gameObject.tag == gameController.getDesiredObject())
            {
                gameController.collectDesired();
            } else if(gameObject.tag == "junk")
            {
                gameController.collectJunk();
            } else
            {
                gameController.collectOther();
            }

            Destroy(gameObject);
        }
        
    }
}
