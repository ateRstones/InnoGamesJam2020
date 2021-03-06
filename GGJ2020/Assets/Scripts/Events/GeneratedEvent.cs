﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratedEvent
{
    public DurationEvent execEvent;
    public float time;

    public bool Activate(float time)
    {
        if(time >= this.time)
        {
            execEvent.Execute(time);
            return true;
        }
        return false;
    }

    public GeneratedEvent(DurationEvent execEvent, float time)
    {
        this.execEvent = execEvent;
        this.time = time;
    }
}
