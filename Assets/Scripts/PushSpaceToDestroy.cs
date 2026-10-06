using UnityEngine;
//This script is to destroy the game object when the space bar is pressed
public class PushSpaceToDestroy : MonoBehaviour
{
    public GameObject objectToDestroy; // Reference to the game object to destroy
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject); Destroys the game object
            //Destroy(this); Destroys the script component instead of the game object
            //Destroy(this.gameObject); // Destroys the game object

            Destroy(objectToDestroy); // Destroys the specified game object
        }
    }
}
