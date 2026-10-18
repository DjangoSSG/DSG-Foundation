using UnityEngine;

public class transformTranslate : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public float sensX;
    public float sensY;
    public Transform orientation;
    float xRotation;
    float yRotation;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        //get mouse input
        float mouseX = Input.GetAxisRaw("mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("mouse Y") * Time.deltaTime * sensY;
        yRotation+= mouseX;
        xRotation-= mouseY;
        xRotation =Mathf.Clamp(xRotation, -90f, 90f);
        // rotate cam and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        transform.rotation = Quaternion.Euler(0, yRotation, 0);
        //move forwards
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward*movementSpeed*Time.deltaTime);
        } 
        //move backwards
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.forward*movementSpeed*Time.deltaTime);
        } 
        //move right
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right*movementSpeed*Time.deltaTime);
        } 
        //move left
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right*movementSpeed*Time.deltaTime);
        } 
        //rotate right
        if(Input.GetKey(KeyCode.R))
        {
            transform.Rotate(transform.up*rotationSpeed*Time.deltaTime);
        }
        //rotate left
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(-transform.up*rotationSpeed*Time.deltaTime);
        }
    }
}
