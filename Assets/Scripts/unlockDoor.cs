using UnityEngine;

public class unlockDoor : MonoBehaviour
{
    public GameObject clickToEnable;
    public NewMonoBehaviourScript keyScript;
    public bool keyEnabled = false;
    public GameObject unlockedDoor;
    void OnMouseDown()
    {
        if (keyScript.keyCollected == true)
        {
            clickToEnable.SetActive(true);
            keyEnabled = true; //used for script to play key turning in door animation
            unlockedDoor.SetActive(true); //crosses off unlock door on UI
        }
    }
}
