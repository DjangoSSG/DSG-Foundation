using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject clickObjToDestroy;
    public bool keyCollected = false;
    public GameObject obtainedKey;
    void OnMouseDown()
    {
        Destroy(clickObjToDestroy);
        keyCollected = true;
        obtainedKey.SetActive(true); //crosses off obtain key on UI
    }

}
