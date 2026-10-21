using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float movepeed;
    public Transform orientation;
    float horizontalInput;
    float verticalInput;
    Vector3 movedirection;
    Rigidbody rb;
    void Start()
    {
      rb = GetComponent<Rigidbody>();
      rb.freezeRotation = true;
    }
    void Update()
    {
        MyInput();
    }
    void FixedUpdate() //fixed update used so speed movement isn't affected by framerate
    {
        MovePlayer();
    }
    void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    void MovePlayer()
    {
        //calculate movement direction
        movedirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(movedirection.normalized * movepeed * 10f, ForceMode.Force);
    }
}
