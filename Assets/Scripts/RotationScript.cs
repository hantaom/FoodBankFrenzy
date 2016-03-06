using UnityEngine;
using System.Collections;

public class RotationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Vector3.down * Time.deltaTime * 100);
	
	}
}
