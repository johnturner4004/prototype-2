using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01Control : MonoBehaviour
{
  public float horizontalInput;
  public float speed = 10.0f;
  //sets max/min x values
  public float xRange = 20.0f;

  public GameObject ProjectilePrefab;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    //prevents player from falling off map
    if (transform.position.x <= -xRange)
    {
      transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    }

    if (transform.position.x >= xRange)
    {
      transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }


    {
      // horizontal controlls
      horizontalInput = Input.GetAxis("Horizontal");
      transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }

    if (Input.GetKeyDown(KeyCode.Space))
    {
      // launch a projectile from the player
      Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
    }
  }
}
