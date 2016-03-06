using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {

	void Start () {
	
	}

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Object")
        {
            Destroy(other.gameObject);
        }

    }
}
