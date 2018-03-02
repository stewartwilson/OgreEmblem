using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierUnit : Unit {

	public SoldierUnit(string id) : base (id)
    {
        unitName = "";
        width = 1;
        height = 1;
        level = 1;
        experience = 0;
        strength = 10;
        dexterity = 10;
        wisdom = 10;
        vitality = 10;
        speed = 10;
        maxHealth = 20;
        health = maxHealth;
        alignment = 50;
        skillList = new Skill[3];
        mainWeapon = CreateInstance("Sword") as Sword;
        canLead = false;
        unitClass = UnitClass.Soldier;

    }

    public new void levelUp()
    {
        base.levelUp();
        strength += 3;
        dexterity += 2;
        wisdom += 0;
        vitality += 2;
        maxHealth += 2;
        health += 2;
    }

    public override int takeAction(UnitGroup enemies, UnitGroup allies)
    {
        Skill toUse = new Slash();
        Unit target = toUse.act(allies,enemies,0);
        if (target != null)
        {
            return target.takeDamage(mainWeapon.attackPower);
        }
        return 0;
    }

    public override int takeDamage(int damage)
    {
        health -= damage;
        return damage;
    }

    public override int takeHealing(int healing)
    {
        health += healing;
        return -healing;
    }
}
