using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected string stateName;  
    

    public virtual void Execute()
    {
        Debug.Log(stateName);
    }
}

public class PlayingState : State
{
    public PlayingState(string name)
    {
        stateName = name;
    }

    public override void Execute()
    {
        Debug.Log(stateName);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Main.singleton.stateMachine.ChangeState(Main.singleton.paused);
        }
    }
}

public class PausedState : State
{
    public PausedState(string name)
    {
        stateName = name;
    }

    public override void Execute()
    {
        Debug.Log(stateName);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Main.singleton.stateMachine.ChangeState(Main.singleton.playing);
        }
    }
}
