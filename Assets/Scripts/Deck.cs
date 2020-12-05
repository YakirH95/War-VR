using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck 
{
    private int cardAmount;
    
    public Deck()
    {
        cardAmount = 52;
    }

    public int Draw()
    {
        if (cardAmount > 0)
        {
            cardAmount--;
            int number = Random.Range(2, 14);
            return number;
        }

        else
        {
            return 0;
        }
    }
}
