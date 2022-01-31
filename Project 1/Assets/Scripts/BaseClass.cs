using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseClass
{
    public enum genders
    {
        MALE,
        FEMALE
    }

    [Header("Infos")]
    public string myName;
    public genders gender;
    public int currentLevel;
    public int currentExp;

    [Header("Stats")]
    public int currentHealth;
    public int maxHealth;
    public int currentStamina;
    public int maxStamina;
    public int currentMana;
    public int maxMana;

    [Header("Physical Attributes")]
    public int constitution;
    public int agility;
    public int reaction;
    public int strength;
    [Header("Mental Attributes")]
    public int willpower;
    public int logic;
    public int intuition;
    public int charisma;

    [Header("Skills")]
    public int statPoints;
    public int skillPoints;
}
