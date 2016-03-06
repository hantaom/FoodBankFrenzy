using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {

	void Start () {
	
	}

    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
