using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class LightPunch : MonoBehaviour, IAttack
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void CheckForLightPunch()
    {
        if (Input.GetButtonDown("Light Punch"))
        {
            Execute();
        }
    }

    public virtual void Execute()
    {
        Debug.Log("Light Punch");
        anim.SetTrigger("Light Punch");
    }

    void Update()
    {
        CheckForLightPunch();
    } 
}
