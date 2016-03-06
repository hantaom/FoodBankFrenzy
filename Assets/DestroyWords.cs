using UnityEngine;
using System.Collections;

public class DestroyWords : MonoBehaviour {

    public int time = 3; //Seconds to read the text

    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
