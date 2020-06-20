using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimChange : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("Up");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetTrigger("Down");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetTrigger("Right");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetTrigger("Left");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Forward");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            animator.SetTrigger("Back");
        }
    }
}
