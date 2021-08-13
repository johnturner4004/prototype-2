using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  // Detects collisions between objects and destroys them
  private void OnTriggerEnter(Collider other)
  {
    if (tag == "Player")
    {
      Destroy(other.gameObject);
    }
    else
    {    
    Destroy(gameObject);
    Destroy(other.gameObject);
    }
  }
}
