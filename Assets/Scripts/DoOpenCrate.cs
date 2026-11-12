using UnityEngine;
public class DoOpenCrate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnMouseDown()
    {
        animator.SetBool("openCrate", true);
    }
}