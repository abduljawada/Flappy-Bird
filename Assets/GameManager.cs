using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject pipePrefab;
    public float maxOffset = 4f;
    public float timeBtwSpawns = 2f;
    float timeTillSpawn = 0;
    int score = 0;
    public static GameManager instance;
    public TMPro.TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1080, 1920, true);
        instance = this;
        timeTillSpawn = timeBtwSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        timeTillSpawn -= Time.deltaTime;
        if (timeTillSpawn <= 0)
        {
            timeTillSpawn = timeBtwSpawns;
            Instantiate(pipePrefab, new Vector3(pipePrefab.transform.position.x, Random.Range(-maxOffset, maxOffset), 0), Quaternion.identity);
        }
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
