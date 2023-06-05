using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnbreakableBlock : Block
{
    public override void TakeDamage(int damage)
    {
        // Do nothing, as the UnbreakableBlock should not take damage
        // You can leave this method empty or add any additional behavior if needed
    }
}
