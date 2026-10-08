using UnityEngine;

public class ClickToDestroy : MonoBehaviour
{
    public GameObject clickObjToDestroy;
    void OnMouseDown()
    {
        Debug.Log("object clicked");
        //Debug.LogError("object clicked"); //This log error will stop play
        //Debug.LogWarning("object clicked");
        Destroy(clickObjToDestroy);
    }

    
}
