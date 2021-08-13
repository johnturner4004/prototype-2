using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
  private float topBound = 30.0f;
  private float lowerBound = -10.0f;
  private float sideBound = 35.0f;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // destroys objects that go out of the field of view
    if (transform.position.z > topBound)
    {
      Destroy(gameObject);
    }
    else if (transform.position.z < lowerBound)
    {
      Debug.Log("Game Over");
      Destroy(gameObject);
    }
    else if (transform.position.x > sideBound)
    {
      Destroy(gameObject);
    }
    else if (transform.position.x < -sideBound)
    {
      Destroy(gameObject);
    }
  }
}
