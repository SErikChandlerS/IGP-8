using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct Movement
{
    public float Speed;
    [NonSerialized] public int Direction;
}
