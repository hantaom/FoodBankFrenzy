using UnityEngine;
using System.Collections;

public class MainMenuButton : MonoBehaviour {

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

        Application.LoadLevel("Main");
        //this.gameObject.GetComponent<levelHandler> ().loadLevel (currentLevel);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
