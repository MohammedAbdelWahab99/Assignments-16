using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerrr : Character
{
    public void Heal(int amount)
    {
        _Character_Health += amount;
    }
}
