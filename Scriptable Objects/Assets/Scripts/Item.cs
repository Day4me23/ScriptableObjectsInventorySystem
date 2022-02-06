using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Slot", menuName = "Slot")]
public class Item : ScriptableObject
{
    public new string name;
    public string description;
    public Sprite icon;

    public int damage;
    public int durability;


    public void Print()
    {
        Debug.Log(name + ": " + description + " Damage: " + damage + " Durability: " + durability);
    }
}
