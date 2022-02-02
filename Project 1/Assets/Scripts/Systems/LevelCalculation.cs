using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCalculation : MonoBehaviour
{
    public int currentLevel;
    public int baseXP = 20;
    public int currentXP;

    public int xpForNextLevel;
    public int xpDiffecenteToNextLevel;
    public int totalXpDifference;
    public float fillAmount;
    public float reversedFillAmount;

    public int statPoints;
    public int skillPoints;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AddXP", 1f, 1f);
    }

    public void  AddXP()
    {
        calculateLevel(5);
    }

    void calculateLevel(int amount)
    {
        currentXP += amount;
        int tempCurLevel = (int)Mathf.Sqrt(currentXP / baseXP);

        if (currentLevel < tempCurLevel)
        {
            currentLevel = tempCurLevel;
        }
        if (currentLevel < 2)
        {
            xpForNextLevel = baseXP*4;
            xpDiffecenteToNextLevel = xpForNextLevel - currentXP;
            totalXpDifference = xpForNextLevel;
            reversedFillAmount = (float)xpDiffecenteToNextLevel / (float)totalXpDifference;
            fillAmount = 1 - reversedFillAmount;
        }
        else
        {
            xpForNextLevel = baseXP * (currentLevel + 1) * (currentLevel + 1);
            xpDiffecenteToNextLevel = xpForNextLevel - currentXP;
            totalXpDifference = xpForNextLevel - (baseXP * currentLevel * currentLevel);
            reversedFillAmount = (float)xpDiffecenteToNextLevel / (float)totalXpDifference;
            fillAmount = 1 - reversedFillAmount;
        }

        statPoints = 5 * currentLevel;
        skillPoints = 15 * currentLevel;
    }
}
