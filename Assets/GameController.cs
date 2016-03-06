using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public Vector3 spawnLocation;
    public float maxX;
    public float minX;
    public GameObject foodObject;
  

    private bool gameOver;
    private bool restart;
    private int score;
    private float time;
    private int numObjects;
    private int startWait;
    private bool paused;
    private int spawnWait;

	void Start () {
        gameOver = false;
        restart = false;
        paused = false;
        score = 0;
        time = 180;
        numObjects = 10;
        startWait = 3;
        spawnWait = 2;
        StartCoroutine(SpawnObjects());
	}
	
	// Update is called once per frame
	void Update () {


    }

    IEnumerator SpawnObjects()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
           
                for (int i = 0; i < numObjects; i++)
                {
                if (!paused)
                {
                    Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), spawnLocation.y, spawnLocation.z);
                    Instantiate(foodObject, spawnPos, foodObject.transform.rotation);
                    yield return new WaitForSeconds(spawnWait);
                }
                }
                //yield return new WaitForSeconds(waveWait);

            
        }
    }

   void GameOver()
    {
        gameOver = true;
    }
    public void pause()
    {
        paused = !paused;
        if (paused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
