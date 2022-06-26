using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class MediumPunch : MonoBehaviour, IAttack
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void CheckForMediumPunch()
    {
        if (Input.GetButtonDown("Medium Punch"))
        {
            Execute();
        }
    }

    public virtual void Execute()
    {
        Debug.Log("Medium Punch");
        anim.SetTrigger("Medium Punch");
    }

    void Update()
    {
        CheckForMediumPunch();
    }
}