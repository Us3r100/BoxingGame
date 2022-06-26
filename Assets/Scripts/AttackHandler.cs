using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
public class AttackHandler : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void ListenForAttack()
    {
        if (Input.GetButtonDown("Light Punch"))
        {
            anim.SetTrigger("Light Punch");
        }
        if (Input.GetButtonDown("Medium Punch"))
        {
            anim.SetTrigger("Medium Punch");
        }
        if (Input.GetButtonDown("Heavy Punch"))
        {
            Debug.Log("Heavy Punch");
            anim.SetTrigger("Heavy Punch");
        }
    }

    // Update is called once per frame
    void Update()
    {
        ListenForAttack();
    }
}
