
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public GameObject[] doorPrefabs;
    public float zSpawn = 0;
    public float doorLength = 30f;
    public int numberOfDoors = 3;

    public Transform player;
    private Transform playerTransform;
    public int spawnedDoors;


    //create a queue of doors in order to run a FIFO
    private Queue<GameObject> doors = new Queue<GameObject>();
    // Start is called before the first frame update
#if UNITY_EDITOR
    void Start()
    {
        for (int i = 0; i < numberOfDoors; i++)
        {
            if (i == 0)
            {
                spawnDoor(0);
            }
            else
            {
                spawnDoor(UnityEngine.Random.Range(0, doorPrefabs.Length));
            }

        }
        playerTransform = player.transform;
    }
#endif

    // Update is called once per frame
#if UNITY_EDITOR
    void Update()
    {
        if (playerTransform.position.z > zSpawn - (numberOfDoors * doorLength))
        {
            spawnDoor(UnityEngine.Random.Range(0, doorPrefabs.Length));
            DeleteDoor();
        }
    }
#endif

    //Code to spawn new platform
    private void spawnDoor(int doorIndex)
    {
        GameObject door = Instantiate(doorPrefabs[doorIndex], transform.forward * zSpawn, transform.rotation);
       doors.Enqueue(door);
        zSpawn += doorLength;
    }

    //Code to destroy old doors
    private void DeleteDoor()
    {
        if (doors.Count >= spawnedDoors)
        {
            GameObject door = doors.Dequeue();
            Destroy(door);
        }
    }
}