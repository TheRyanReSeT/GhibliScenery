using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 2;
    private float timer = 0;
    public float pipeOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            float lowestPoint = transform.position.y - pipeOffset;
            float highestPoint = transform.position.y + pipeOffset;
            Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);

            timer = 0;
        }
    }

    void spawnCloud()
    {
        Instantiate(cloud, transform.position, transform.rotation);
    }
}
