using UnityEngine;

public class Movement : MonoBehaviour
{

  // movement
  [SerializeField] float speed = 0.01f;
  [SerializeField] float rotationSpeed = 0.5f;

  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    // get input to move the object
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");

    transform.Translate(0f, verticalInput * speed, 0f);
    transform.Rotate(0f, 0f, - horizontalInput * rotationSpeed);
  }
}
