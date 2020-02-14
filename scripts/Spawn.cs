using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public GameObject box;
    public float spawnRate;
    public float nextSpawn;
    public Text scoreText;
    private int scoreNumber;

    void Update()
    {
        spawn();
    }

    private void Start()
    {
        spawnRate = 3f;
        nextSpawn = 0f;
    }

    public void spawn()
    {
        scoreNumber = int.Parse(scoreText.text);

        if(Time.time > nextSpawn)
        {
            if(scoreNumber >= 50 && scoreNumber < 100)
            {
                spawnRate = 2.5f;
            }
            else if (scoreNumber >= 100 && scoreNumber < 150)
            {
                spawnRate = 2.0f;
            }else if (scoreNumber >= 150 && scoreNumber < 200)
            {
                spawnRate = 1.5f;
            }else if(scoreNumber >= 200 && scoreNumber < 250)
            {
                spawnRate = 1.0f;
            }
            else if(scoreNumber >= 250 && scoreNumber < 300)
            {
                spawnRate = 0.75f;
            }
            else if(scoreNumber >=300)
            {
                spawnRate = 0.55f;
            }


                Instantiate(box, transform.position, Quaternion.identity);
            
            nextSpawn = Time.time + spawnRate;
            
        }
        
    }

}
