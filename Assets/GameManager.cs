using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pipePrefab;
    public float maxOffset = 4f;
    public float timeBtwSpawns = 2f;
    private float _timeTillSpawn;
    private int _score;
    public static GameManager Instance;
    public TMPro.TMP_Text scoreText;
    
    private void Start()
    {
        Screen.SetResolution(1080, 1920, true);
        Instance = this;
        _timeTillSpawn = timeBtwSpawns;
    }


    private void Update()
    {
        _timeTillSpawn -= Time.deltaTime;
        if (!(_timeTillSpawn <= 0)) return;
        _timeTillSpawn = timeBtwSpawns;
        Instantiate(pipePrefab, new Vector3(pipePrefab.transform.position.x, Random.Range(-maxOffset, maxOffset), 0), Quaternion.identity);
    }

    public void AddScore()
    {
        _score++;
        scoreText.text = _score.ToString();
    }
}
