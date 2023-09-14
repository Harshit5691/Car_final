using UnityEngine;

public class Trigger : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleAnimatorParameters();
        }
    }

    private void ToggleAnimatorParameters()
    {
        // Toggle all parameters based on their current values
        animator.SetBool("bool 1", !animator.GetBool("bool 1"));
        animator.SetBool("bool 2", !animator.GetBool("bool 2"));
        animator.SetBool("bool 3", !animator.GetBool("bool 3"));
        animator.SetBool("bool 4", !animator.GetBool("bool 4"));
        animator.SetBool("bool 5", !animator.GetBool("bool 5"));
        animator.SetBool("bool 6", !animator.GetBool("bool 6"));
        animator.SetBool("bool 7", !animator.GetBool("bool 7"));
        animator.SetBool("bool 8", !animator.GetBool("bool 8"));
        animator.SetBool("bool 9", !animator.GetBool("bool 9"));
        animator.SetBool("bool 10", !animator.GetBool("bool 10"));
        animator.SetBool("bool 11", !animator.GetBool("bool 11"));
        animator.SetBool("bool 12", !animator.GetBool("bool 12"));
        animator.SetBool("bool 13", !animator.GetBool("bool 13"));
        animator.SetBool("bool 14", !animator.GetBool("bool 14"));
    }
}
