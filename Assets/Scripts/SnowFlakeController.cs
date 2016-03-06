using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class SnowFlakeController : MonoBehaviour {

    public Vector3 spawnLocation;
    public float maxX;
    public float minX;
    public GameObject foodObject;

    private int startWait;
    private bool paused;
    private int spawnWait;
    private float waveWait;
    private string desiredCategory;
    private int numObjects;



    void Start()
    {

        paused = false;
        waveWait = 0.3f;
        startWait = 0;
        spawnWait = 0;
        StartCoroutine(SpawnObjects());
        numObjects = 10;
    }


    void Update()
    {    
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
                    
                    Vector3 spawnPos = new Vector3(UnityEngine.Random.Range(minX, maxX), spawnLocation.y, spawnLocation.z);
                    Instantiate(foodObject, spawnPos, foodObject.transform.rotation);

                    yield return new WaitForSeconds(waveWait);

                    Vector3 spawnPos1 = new Vector3(UnityEngine.Random.Range(minX, maxX), spawnLocation.y, spawnLocation.z);
                    Instantiate(foodObject, spawnPos1, foodObject.transform.rotation);

                    yield return new WaitForSeconds(waveWait);

                    Vector3 spawnPos2 = new Vector3(UnityEngine.Random.Range(minX, maxX), spawnLocation.y, spawnLocation.z);
                    Instantiate(foodObject, spawnPos2, foodObject.transform.rotation);

                    yield return new WaitForSeconds(waveWait);

                    Vector3 spawnPos3 = new Vector3(UnityEngine.Random.Range(minX, maxX), spawnLocation.y, spawnLocation.z);
                    Instantiate(foodObject, spawnPos3, foodObject.transform.rotation);
                    yield return new WaitForSeconds(waveWait);

                    Vector3 spawnPos4 = new Vector3(UnityEngine.Random.Range(minX, maxX), spawnLocation.y, spawnLocation.z);
                    Instantiate(foodObject, spawnPos4, foodObject.transform.rotation);
                    yield return new WaitForSeconds(waveWait);

                    Vector3 spawnPos5 = new Vector3(UnityEngine.Random.Range(minX, maxX), spawnLocation.y, spawnLocation.z);
                    Instantiate(foodObject, spawnPos5, foodObject.transform.rotation);
                    yield return new WaitForSeconds(waveWait);
                }

                yield return new WaitForSeconds(waveWait);
            }
        }
    }

    void updateTime()
    {
        
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

    public string getDesiredCategory()
    {
        return desiredCategory;
    }



    void pickNewCategory(String category)
    {
        if (category == "Fruit")
        {
            pickBetween("CannedFood", "Carbs");
        }
        else if (category == "Carbs")
        {
            pickBetween("Fruit", "CannedFood");
        }
        else pickBetween("Carbs", "Fruit");
    }
    void pickBetween(String opt1, String opt2)
    {
        System.Random rnd = new System.Random();
        int rand = rnd.Next(1, 3);
        switch (rand)
        {
            case 1:
                desiredCategory = opt1;
                break;
            case 2:
                desiredCategory = opt2;
                break;
        }
    }
}

