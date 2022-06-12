using UnityEngine;

public class MeteorSpawn : MonoBehaviour
{
    public GameObject meteorPrefab;
    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 3f;

    void Start()
    {
        Spawn();
    }
    void Spawn()
    {
        // Create a meteor at a random x position
        Vector3 spawnPos = new Vector2(Random.Range(-6, 6), 6f);

        Instantiate(meteorPrefab, spawnPos, Quaternion.identity);

        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }

}
