using UnityEngine;

public class TransformTranslate1 : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0,0,1);
            Debug.Log("S Key Pressed");
        }   
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0,0,-1);
            Debug.Log("W Key Pressed");
        }   
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-1,0,0);
            Debug.Log("A Key Pressed");
        }   
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(1,0,0);
            Debug.Log("D Key Pressed");
        }
        //up and down movement    
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0,1,0);
            Debug.Log("Space Key Pressed");
        }
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            transform.Translate(0,-1,0);
            Debug.Log("Left Control Key Pressed");
        }*/
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward*movementSpeed*Time.deltaTime);
        } 
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(-transform.forward*movementSpeed*Time.deltaTime);
        } 
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right*movementSpeed*Time.deltaTime);
        } 
        if(Input.GetKey(KeyCode.D))
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
