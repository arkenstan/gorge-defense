using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

  public float speed = 10f;
  public float xForce = 10.0f;
  public float zForce = 10.0f;
  public float yForce = 500.0f;
  public float maxSpeed = 200f;

  Rigidbody rb;
  Vector3 initPosition;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
    rb.rotation = Quaternion.identity;
    rb.freezeRotation = true;
  }

  // Update is called once per frame
  void Update()
  {
    movementControl();
  }

  private void movementControl()
  {
    float x = 0.0f;
    if (Input.GetKey(KeyCode.A))
    {
      x = x - xForce;
    }

    if (Input.GetKey(KeyCode.D))
    {
      x = x + xForce;
    }


    float z = 0.0f;
    if (Input.GetKey(KeyCode.S))
    {
      z = z - zForce;
    }

    if (Input.GetKey(KeyCode.W))
    {
      z = z + zForce;
    }

    float y = 0.0f;


    rb.AddForce(x, y, z);

    if (rb.velocity.magnitude > maxSpeed)
    {
      rb.velocity = rb.velocity.normalized * maxSpeed;
    }

  }

}
