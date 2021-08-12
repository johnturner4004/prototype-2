using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01Control : MonoBehaviour
{
  // gets input from the player
  public float horizontalInput;
  public float verticalInput;
  //speed and range for player motion
  private float speed = 20.0f;
  //sets max/min x values
  private float xRange = 20.0f;
  //sets max/min z values
  private float zLower = -5.0f;
  private float zUpper = 10.0f;

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

    if (transform.position.z <= zLower)
    {
      transform.position = new Vector3(transform.position.x, transform.position.y, zLower);
    }

    if (transform.position.z >= zUpper)
    {
      transform.position = new Vector3(transform.position.x, transform.position.y, zUpper);
    }


    {
      // horizontal controlls
      horizontalInput = Input.GetAxis("Horizontal");
      transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }

    {
      // vertical controls
      verticalInput = Input.GetAxis("Vertical");
      transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
    }

    if (Input.GetKeyDown(KeyCode.Space))
    {
      // launch a projectile from the player
      Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
    }
  }
}
