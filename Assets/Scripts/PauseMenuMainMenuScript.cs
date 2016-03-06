using UnityEngine;
using System.Collections;

public class PauseMenuMainMenuScript : MonoBehaviour
{

    bool moved = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pauseMenu()

    {
        if (!moved)
        {
            transform.position = new Vector3(transform.position.x - 2.89F, transform.position.y, transform.position.z);
            moved = true;
        }
        else
        {
            transform.position = new Vector3(transform.position.x + 2.89F, transform.position.y, transform.position.z);
            moved = false;
        }
    }
}
