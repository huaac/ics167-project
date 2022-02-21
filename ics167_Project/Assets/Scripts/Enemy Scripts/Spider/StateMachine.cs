﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : KillableEnemy
{
    BaseState currentState;
    //public static StateMachine instance;

    void Start()
    {
        //StateMachine.instance = this;
        currentState = GetInitialState();
        if (currentState != null)
            currentState.Enter();
    }

    void Update()
    {
        if (currentState != null)
            currentState.UpdateLogic();
    }

    void LateUpdate()
    {
        if (currentState != null)
            currentState.UpdatePhysics();
    }

    public void ChangeState(BaseState newState)
    {
        currentState.Exit();

        currentState = newState;
        currentState.Enter();
    }

    protected virtual BaseState GetInitialState()
    {
        return null;
    }
}