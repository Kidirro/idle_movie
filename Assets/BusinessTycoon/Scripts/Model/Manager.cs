using System;
using System.Runtime.Serialization;

[Serializable]
public class Manager
{
    public int Id = 0;
    [NonSerialized]
    public int BusinessId = 0;
    [NonSerialized]
    public int CurrencyId = 0;
    [NonSerialized]
    public string Name = "";
    [NonSerialized]
    public double Cost = 0;
    [NonSerialized]
    public string EffectType = "";
    [NonSerialized]
    public double Effect = 0;
    public bool Unlocked = false;
}