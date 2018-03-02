using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Unit : ScriptableObject {

    public string id;
    public string unitName;
    public UnitClass unitClass;
    public int width;
    public int height;
    public int level;
    public int experience;
    public int strength;
    public int dexterity;
    public int wisdom;
    public int vitality;
    public int speed;
    public int health;
    public int maxHealth;
    public int alignment;
    public int critChance;
    public Skill[] skillList = new Skill[3];
    public Weapon mainWeapon;
    public bool canLead;
    public bool isEnemy;

    public Unit(string id)
    {
        this.id = id; 
    }

    private int generateUniqueID()
    {
        int uniqueID = 0;

        return uniqueID;
    }

    public void levelUp()
    {
        level++;
        experience -= 100;
    }

    public abstract int takeAction(UnitGroup enemies, UnitGroup allies);

    public abstract int takeDamage(int damage);

    public abstract int takeHealing(int healing);

}
