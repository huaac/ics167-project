﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "FSM/Decisions/Found Enemy")]
public class FoundEnemyDecision : Decision
{
    public override bool Decide(HelperFSM machine)
    {
        GameObject possibleEnemy = machine.Detector.EnteredEnemy;

        return possibleEnemy != null;
    }
}
