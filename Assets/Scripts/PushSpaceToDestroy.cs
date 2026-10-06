using UnityEngine;
//This script is to destroy the game object when the space bar is pressed
public class PushSpaceToDestroy : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
