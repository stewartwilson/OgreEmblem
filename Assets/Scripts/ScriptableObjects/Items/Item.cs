using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Item : ScriptableObject {

    public float id;
    public string itemName;
    public string description;
    public int value;

}
