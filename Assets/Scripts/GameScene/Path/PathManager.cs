using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    public GameObject[] pathPrefabs;
    public float zSpawn = 0; //spawn edeceğimiz konum için
    public float pathLenght = 300;
    public Transform playerTransform;
    public float lastPos;

    private int numberOfPaths = 7;
    private List<GameObject> activePaths = new List<GameObject>();
    
    void Start()
    {
        for(int i = 1; i < numberOfPaths; i++)
        {
            if(i == 0)
                SpawnPath(0);
            else
            {
                SpawnPath(Random.Range(0, pathPrefabs.Length));
            }
        }
    }
    
    void Update()
    {
        if(playerTransform.position.z - 550 > (zSpawn - (numberOfPaths * pathLenght)))
        {
            SpawnPath(Random.Range(0, pathPrefabs.Length));
            lastPos = zSpawn;
            DeletePath();
        }
    }

    public void SpawnPath(int pathIndex)
    {
        GameObject paths = Instantiate(pathPrefabs[pathIndex], transform.forward * zSpawn, transform.rotation);
        activePaths.Add(paths);
        zSpawn += pathLenght;
    }
    
    

    private void DeletePath()
    {
        Destroy(activePaths[0]);
        activePaths.RemoveAt(0);
    }
}
