using UnityEngine;

public class DoKeyAnimation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Animator animator;
    public unlockDoor doorScript;
    public bool gnomeFree = false; //checks if the gnome is free to transition to victory scene
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (doorScript.keyEnabled == true) //checks if the door has been clicked while key is collected to trigger key animation
        {
            animator.SetBool("KeyCollected", true);
            gnomeFree = true; //sets gnomeFree to true to allow transition to victory scene
        }
    }
}
