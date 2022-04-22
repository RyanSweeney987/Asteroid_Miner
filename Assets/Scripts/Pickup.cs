using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Pickup : ScriptableObject
{
    public PickupType type;
    public float value;
}
    
public enum PickupType
{
    Fuel,
    Ship,
    Ore
}