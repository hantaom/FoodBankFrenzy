using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour {

    private int cameraState = Animator.StringToHash("moveCamera");
    private Animator cameraAnimator;

    // Use this for initialization
    void Start()
    {
        //PlayerPrefs.DeleteAll ();
        cameraAnimator = this.transform.GetComponent<Animator>();
        //aSource = this.GetComponents<AudioSource> ();
    }

    // Update is called once per frame
    void Update () {
	
	}

    public void startGame()
    {
        cameraAnimator.SetInteger(cameraState, 4);
    }
}
