using UnityEngine;

public class unlockDoor : MonoBehaviour
{
    public GameObject clickToEnable;
    public NewMonoBehaviourScript keyScript;
    public bool keyEnabled = false;
    public bool keyDone = false; //variable used to disable key2 before doing open door animation
    public bool gnomeGone;
    public GameObject unlockedDoor;
    doDoorAnimation doorAnimation;

    void Start()
    {
        doorAnimation = GetComponentInParent<doDoorAnimation>();
    }
    void OnMouseDown()
    {
        if (keyScript.keyCollected == true)
        {
            clickToEnable.SetActive(true);//used to enable key 2
            keyEnabled = true; //used for script to play key turning in door animation
            unlockedDoor.SetActive(true); //crosses off unlock door on UI            
            Invoke("doOpenDoorAnimation", 3); //waits for 3 seconds to allow key animation to play before playing the open door animation
        }
    }
    void doOpenDoorAnimation()
    {
        keyDone = true; //disables key2 before opening door
        doorAnimation.OpenDoor();
        Invoke("gnomeLeave", 1);
    }
    void gnomeLeave()
    {
        gnomeGone = true;
    }
}
