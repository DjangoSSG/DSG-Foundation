using UnityEngine;
//This script is for a debug statement
public class HelloWorldDebug : MonoBehaviour
{
    void OnEnable()
    {
        Debug.Log("My dog's on fire!");
    }
    void OnDisable()
    {
        Debug.Log("My dog's not on fire!");
    }
}
