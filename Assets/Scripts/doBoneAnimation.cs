using UnityEditor;
using UnityEngine;

public class doBoneAnimation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Animator animator;
    public Component componentToDestroy;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnMouseDown()
    {
        animator.SetBool("BonePileClicked", true);
         Destroy(componentToDestroy);
    }
}