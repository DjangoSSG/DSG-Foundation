using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject clickObjToDestroy;
    public bool keyCollected = false;
    void OnMouseDown()
    {
        Destroy(clickObjToDestroy);
        keyCollected = true;
    }

}
