using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
    bool paused;
    private GameController gameController;
    
    private Animator cameraAnimator;
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
       

        paused = !paused;
        if (paused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
         
        gameController.pause();

    }
}
