using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
public class AttackHandler : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    [SerializeField]
    string lightPunchInput = "Light Punch";
    [SerializeField]
    string mediumPunchInput = "Medium Punch";
    [SerializeField]
    string heavyPunchInput = "Heavy Punch";
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void ListenForAttack()
    {
        bool attacked = false;
        if (Input.GetButtonDown(lightPunchInput))
        {
            anim.SetTrigger("Light Punch");
            attacked = true;
        }
        if (Input.GetButtonDown(mediumPunchInput))
        {
            anim.SetTrigger("Medium Punch");
            attacked = true;
        }
        if (Input.GetButtonDown(heavyPunchInput))
        {
            anim.SetTrigger("Heavy Punch");
            attacked = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        ListenForAttack();
    }
}
