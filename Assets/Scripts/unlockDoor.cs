using UnityEngine;

public class unlockDoor : MonoBehaviour
{
    public GameObject clickToEnable;
    public NewMonoBehaviourScript keyScript;

    void OnMouseDown()
    {
        if (keyScript.keyCollected == true)
        {
            clickToEnable.SetActive(true);
        }
    }
}
