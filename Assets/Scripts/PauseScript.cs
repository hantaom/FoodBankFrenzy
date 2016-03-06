using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
 
    private GameController gameController;
    // Use this for initialization
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Pause()
    {
        gameController.pause();

    }
}
