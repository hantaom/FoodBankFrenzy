using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Vector3 spawnLocation;
    public float maxX;
    public float minX;
    public GameObject foodObject;
    public Text timerText;
    public Text scoreText;
  

    public bool gameOver;
    private bool restart;
    private int score;
    private float totalTime;
    private int minutes;
    private int seconds;
    private int numObjects;
    private int startWait;
    private bool paused;
    private int spawnWait;
    private int waveWait;
    private string desiredObject;


    void Start () {
        gameOver = false;
        restart = false;
        paused = false;
        score = 0;
        totalTime = 15f;
        numObjects = 10;
        waveWait = 0;
        startWait = 3;
        spawnWait = 1;
        desiredObject = "Fruit";
        StartCoroutine(SpawnObjects());
    }
	
	
	void Update () {
        if (totalTime > 1)
        {
            totalTime -= Time.deltaTime;
        }
        minutes = Mathf.FloorToInt(totalTime / 60F);
        seconds = Mathf.FloorToInt(totalTime - minutes * 60);
        updateTime();
        updateScore();
        if (totalTime < 1)
        {
            GameOver();
            


        }
    }

    IEnumerator SpawnObjects()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
           for (int i = 0; i < numObjects; i++){
                if (!paused)
                {
                    if (gameOver) break;
                    Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), spawnLocation.y, spawnLocation.z);
                    Instantiate(foodObject, spawnPos, foodObject.transform.rotation);
                    yield return new WaitForSeconds(spawnWait);
                }
            }
            yield return new WaitForSeconds(waveWait);
        }
    }

    void updateTime()
    {
        timerText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
    }

   public void GameOver()
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

    public string getDesiredObject()
    {
        return desiredObject;
    }
    public void collectDesired()
    {
        score += 10;
        updateScore();
    }
    public void collectJunk()
    {
        score -= 20;
        if(score < 0)
        {
            score = 0;
        }
        updateScore();
    }
    public void collectOther()
    {
        score -= 10;
        if (score < 0)
        {
            score = 0;
        }
        updateScore();
    }
    public void updateScore()
    {
        scoreText.text = "" + score;
    }
}
