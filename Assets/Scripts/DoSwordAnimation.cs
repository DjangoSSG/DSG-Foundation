using UnityEngine;

public class DoSwordAnimation : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnMouseDown()
    {
        animator.SetBool("swordClicked", true);
    }
}
