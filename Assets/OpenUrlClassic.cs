using UnityEngine;
using System.Collections;

public class OpenUrlClassic : MonoBehaviour {

	// Use this for initialization
	public void openUrl()
    {
        Application.OpenURL("https://www.foodbank.bc.ca/contact-us/");
    }
}
