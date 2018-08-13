using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {

    public int columnSize = 5;
    public GameObject columnPrefab;
    private GameObject[] columns;
    private float spawnRate = 4f;
    private float timeSinceLastSpawn;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    public float columnMin = -1.5f;
    public float columnMax = 3.5f;
    private float spawnXposition=10f;
    private int currentColumn = 0;
    // Use this for initialization
	void Start () {
        timeSinceLastSpawn = 0f;
        columns = new GameObject[columnSize];
		for(int i=0;i<columnSize;i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastSpawn += Time.deltaTime;
        if(GameController.instance.gameOver==false&&timeSinceLastSpawn>=spawnRate)
        {
            timeSinceLastSpawn = 0f;
            float spawnPosition = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(spawnXposition, spawnPosition);
            currentColumn++;
            if(currentColumn>=columnSize)
            {
                currentColumn = 0;
            }
        }
	}
}
