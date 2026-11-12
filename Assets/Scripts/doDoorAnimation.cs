using UnityEngine;

public class doDoorAnimation : MonoBehaviour
{
    Animator openDoorAnimator;

    void Start()
    {
        openDoorAnimator = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        openDoorAnimator.SetBool("OpenDoor", true);
    }
}