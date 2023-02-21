using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 1f;
    bool isScored = false;
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        if (transform.position.x <= -0.5f && !isScored)
        {
            GameManager.instance.AddScore();
            isScored = true;
            source.Play();
        }
        if (transform.position.x <= -6)
        {
            Destroy(gameObject);
        }
    }
}
