using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRooms : MonoBehaviour
{
    public GameObject placeholderSquare;
    public GameObject[] rooms;
    private Dictionary<int, GameObject> spawnedRooms = new Dictionary<int, GameObject>();
    private Transform player;
    public int recentSpawn = 0;
    private const int roomOffsets = 20;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        for(int i = 0; i < 5; i++)
        {
            spawnRoom(i, 1, 0);
            // room = Instantiate(rooms[Random.Range(0, rooms.Length)], new Vector3(roomOffsets * i, 0.0f, 0.0f), Quaternion.identity);
        }
        recentSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(((int)player.position.x) / roomOffsets != recentSpawn)
        {
            int newOffset = ((int)player.position.x) / roomOffsets;
            int direction = 1;
            if(newOffset < recentSpawn)
                direction = -1;
            spawnRoom(newOffset, direction);
        }

        if(placeholderSquare != null && Mathf.Abs(player.position.x - placeholderSquare.transform.position.x) > 5 * roomOffsets)
        {
            Destroy(placeholderSquare);
            placeholderSquare = null;
        }
    }

    private void spawnRoom(int newOffset, int direction=1, int adder=4)
    {
        int xPos = roomOffsets * ((adder * direction) + newOffset);
        if(spawnedRooms.ContainsKey(xPos))
        {
            Destroy(spawnedRooms[xPos]);
        }
        GameObject room = Instantiate(rooms[Random.Range(0, rooms.Length)], new Vector3(xPos, 0.0f, 0.0f), Quaternion.identity);
        spawnedRooms[xPos] = room;
        recentSpawn = newOffset;
    }
}
