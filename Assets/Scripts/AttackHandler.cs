using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
public class AttackHandler : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    Transform hitboxPoint;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        hitboxPoint = transform.Find("HitboxPoint").transform;
    }

    void ListenForAttack()
    {
        bool attacked = false;
        if (Input.GetButtonDown("Light Punch"))
        {
            anim.SetTrigger("Light Punch");
            attacked = true;
        }
        if (Input.GetButtonDown("Medium Punch"))
        {
            anim.SetTrigger("Medium Punch");
            attacked = true;
        }
        if (Input.GetButtonDown("Heavy Punch"))
        {
            anim.SetTrigger("Heavy Punch");
            attacked = true;
        }
        if (attacked)
        {
            // The animation handles setting to false after the attack is done.
            hitboxPoint.gameObject.SetActive(true);
        }
    }

    // Called using Animation Events, spawns a hitbox and checks for collisions.
    public void CheckForCollisionDuringAttack()
    {
        Collider2D[] hitColliders = Physics2D.OverlapBoxAll(hitboxPoint.position, new Vector2(0.5f, 0.5f), 0);
        foreach (Collider2D hitCollider in hitColliders)
        {
            //TODO: Check if the hitCollider is the opponent.
            // if (hitCollider.gameObject.tag == "Enemy")
            // {
            //     hitCollider.gameObject.GetComponent<Enemy>().TakeDamage(10);
            // }
        }
    }

    private void OnDrawGizmos() {
        if (hitboxPoint != null)
        {
            Gizmos.DrawWireCube(hitboxPoint.position, new Vector3(0.5f, 0.5f, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        ListenForAttack();
    }
}
