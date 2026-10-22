using UnityEngine;

public class clickOnCube : MonoBehaviour
{
    Animator animator;
    // Update is called once per frame
    void Start()
    {
        animator = GetComponent<Animator>();
        OnMouseDown();
    }
    void OnMouseDown()
    {
        if (animator.GetBool("isClicked") == false)
        {
            animator.SetBool("isClicked", true);
        }
        else
        {
            animator.SetBool("isClicked", false);
        }
    }
}
