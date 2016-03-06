using UnityEngine;
using System.Collections;

public class DetectEnd : MonoBehaviour {

    private GameController gameController;
    private int cameraState = Animator.StringToHash("moveCamera");
    private Animator cameraAnimator;

    // Use this for initialization
    void Start () {

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        cameraAnimator = this.transform.GetComponent<Animator>();

    }

    public void StartGame()
    {
        cameraAnimator.SetInteger(cameraState, 2);
    }
	
	// Update is called once per frame
	void Update () { 
        
	
	}
}
