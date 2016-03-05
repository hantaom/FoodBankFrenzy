using UnityEngine;
using System.Collections;

public class lightSwitch : MonoBehaviour {


	public bool isOn = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void change(){

		Vector3 curPos = this.transform.FindChild ("Plane").position;

		if(isOn){

			isOn = false;
			this.transform.FindChild("Plane").position = new Vector3(curPos.x,curPos.y,curPos.z +.5f);
			//this.transform.localEulerAngles = new Vector3(0,45,0);
		
		}else{
			isOn = true;
			this.transform.FindChild("Plane").position = new Vector3(curPos.x,curPos.y,curPos.z -.5f);
			//this.transform.localEulerAngles = Vector3.zero;
		}
	}



}
