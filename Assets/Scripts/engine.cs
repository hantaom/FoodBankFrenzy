using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class engine : MonoBehaviour {

	int nrOfLevels;
	public int currentLevel;
	public int nrOfMoves;

	public AudioSource[] aSource;

	private int cameraState = Animator.StringToHash("moveCamera");
	private Animator cameraAnimator;



	// Use this for initialization
	void Start () {
		//PlayerPrefs.DeleteAll ();
		cameraAnimator = this.transform.GetComponent<Animator> ();
		aSource = this.GetComponents<AudioSource> ();
	}

	public void init(int nr){

		nrOfLevels = nr;
		currentLevel = getProgress ();
	}

	int getProgress(){

		int progint = 0;

		for (int i=1; i <nrOfLevels+1; i++) {


			if(PlayerPrefs.HasKey(i.ToString())){
				progint++;
			}else{
				progint++;
				break;
			}
		}
		return progint;
	}

	int getScore(string lev){
		return PlayerPrefs.GetInt (lev);
	}

	void saveGame(){
		if(PlayerPrefs.HasKey(currentLevel.ToString())){
			if(getScore(currentLevel.ToString()) > nrOfMoves){
				PlayerPrefs.SetInt(currentLevel.ToString(), nrOfMoves);
			}
		}else{
			PlayerPrefs.SetInt(currentLevel.ToString(), nrOfMoves);
		}
	}

	public void startGame(){

		cameraAnimator.SetInteger (cameraState, 1);
		this.gameObject.GetComponent<levelHandler> ().loadLevel (currentLevel);
	}

	public void gameFinished(){
		aSource [0].Play ();
		cameraAnimator.SetInteger (cameraState, 2);
		saveGame ();
		currentLevel++;
		nrOfMoves = 0;
		Invoke ("animationDone", 1.0f);
	}

	public void playClickSound(){
		aSource [1].Play ();
	}


	void animationDone(){

		if(currentLevel<nrOfLevels+1){
			cameraAnimator.SetInteger (cameraState, 1);
			this.gameObject.GetComponent<levelHandler> ().loadLevel (currentLevel);	
		}else{
			GameObject.Find("Hub").transform.FindChild("headline").GetComponent<Text>().text = "GAME COMPLETED";
		}


	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
