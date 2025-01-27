using System;
using System.Runtime.Serialization;

[Serializable]
public class Milestone
{
    public int Id = 0;
    [NonSerialized]
    public int BusinessId = 0;
    [NonSerialized]
    public int Count = 0;
    [NonSerialized]
    public int TargetId = 0;
    [NonSerialized]
    public string EffectType = "";
    [NonSerialized]
    public double Effect = 0;
    public bool Unlocked = false;
}
