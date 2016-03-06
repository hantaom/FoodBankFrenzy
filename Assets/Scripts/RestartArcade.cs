using UnityEngine;
using System.Collections;

public class RestartArcade : MonoBehaviour {

    // Use this for initialization
    private int cameraState = Animator.StringToHash("moveCamera");
    private Animator cameraAnimator;

    // Use this for initialization
    void Start()
    {
        //PlayerPrefs.DeleteAll ();
        cameraAnimator = this.transform.GetComponent<Animator>();
        //aSource = this.GetComponents<AudioSource> ();
    }

    public void startGame()
    {

        //cameraAnimator.SetInteger(cameraState, 1);
        Application.LoadLevel("ArcadeMode");
        //this.gameObject.GetComponent<levelHandler> ().loadLevel (currentLevel);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
