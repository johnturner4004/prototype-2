using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
  public GameObject dogPrefab;
  public bool allowDog = true;

  // Update is called once per frame
  void Update()
  {
    // On spacebar press, send dog
    if (Input.GetKeyDown(KeyCode.Space) && allowDog)
    {
      StartCoroutine(Dog());
      Debug.Log("Dog sent!");
    }
  }

  IEnumerator Dog()
  {
    allowDog = false;
    Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    yield return new WaitForSeconds(1.0f);
    allowDog = true;
  }
}
