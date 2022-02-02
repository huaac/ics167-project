﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatTrap : KillableEnemy
{
    Animator myAnimator;

    public override void OnCollisionEnter2D(Collision2D col)
    {
        // if player toucches the rat trap, rat trap animation and they fall down
        if(col.gameObject.tag == "Player")
        {
            myAnimator = GetComponent<Animator>();
            myAnimator.SetTrigger("Touched");
            col.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            TakeDamage(50);
            CallResetScene();
        }
    }

}