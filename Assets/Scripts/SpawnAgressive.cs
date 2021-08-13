using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAgressive : MonoBehaviour
{
  public GameObject[] agressivePrefabs;
  private float spawnXPosition = 30.0f;
  private float[] spawnRangeX = { -30.0f, 30.0f };
  private float spawnZLower = -5.0f;
  private float spawnZUpper = 10.0f;
  private float spawnDelay = 2.0f;
  private float spawnInterval = 1.5f;

  // Start is called before the first frame update
  void Start()
  {
    InvokeRepeating("SpawnRandomAgressive", spawnDelay, spawnInterval);
  }

  // Update is called once per frame
  void Update()
  {

  }

  void SpawnRandomAgressive()
  {
    int randomIndex = Random.Range(0, agressivePrefabs.Length);
    Vector3 spawnPosition = new Vector3(spawnRangeX[Random.Range(0, spawnRangeX.Length)], 0, Random.Range(spawnZLower, spawnZUpper));
    int agressiveRotation;
    if (spawnPosition.x <= 0)
    {
      agressiveRotation = 90;
    }
    else
    {
      agressiveRotation = -90;
    };

    Quaternion direction = Quaternion.Euler(0, agressiveRotation, 0);

    Instantiate(agressivePrefabs[randomIndex], spawnPosition, direction);
  }
}
