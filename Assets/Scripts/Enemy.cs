using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public void Attack(int damage)
    {
        _Character_Health -= damage;
    }
}
