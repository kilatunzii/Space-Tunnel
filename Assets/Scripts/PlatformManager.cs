

using System.Collections.Generic;
using UnityEngine;



public class PlatformManager : MonoBehaviour
{
    public GameObject[] platformPrefabs;
    public float zSpawn = 0;
    public float platformLength = 30f;
    public int numberOfPlatforms = 3;

    public Transform player;
    private Transform playerTransform;
    public int spawnedPlatforms;
    

    //create a queue of platforms in order to run a FIFO
    private Queue<GameObject> platforms = new Queue<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            if (i == 0)
            {
                spawnPlatform(0);
            }
            else
            {
                spawnPlatform(Random.Range(0, platformPrefabs.Length));
            }

            
        }
        playerTransform = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z > zSpawn - (numberOfPlatforms * platformLength))
        {
            spawnPlatform(Random.Range(0, platformPrefabs.Length));
            DeletePlatform();
        }
    }

    //Code to spawn new platform
    private void spawnPlatform(int platformIndex)
    {
        GameObject platform = Instantiate(platformPrefabs[platformIndex], transform.forward * zSpawn, transform.rotation);
        platforms.Enqueue(platform);
        zSpawn += platformLength;
    }

    //Code to destroy old platforms
    private void DeletePlatform()
    {
        if (platforms.Count >= spawnedPlatforms)
        {
            GameObject platform = platforms.Dequeue(); 
            Destroy(platform);
        }
    }
}
