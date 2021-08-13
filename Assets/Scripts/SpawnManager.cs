using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  // holds the list of all spawned objects
  public GameObject[] animalPrefabs;
  // positions where animals can be spawned
  private float spawnRangeX = 20.0f;
  private float spawnRangeZ = 20.0f;
  // time before first spawn
  private float spawnDelay = 2.0f;
  // time between spawns
  private float spawnInterval = 2.0f;
  // Start is called before the first frame update
  void Start()
  {
    // calls spawnrandomanimals() every spawnInterval seconds
    InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
  }

  // Update is called once per frame
  void Update()
  {
    
  }

  // Spawns a random animal at a random x position
  void SpawnRandomAnimal()
  {
    int animalIndex = Random.Range(0, animalPrefabs.Length);
    Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
    Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
  }
}
