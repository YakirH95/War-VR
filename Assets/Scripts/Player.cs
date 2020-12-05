using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player 
{
    private Deck deck;
   
    public Player()
    {
        deck = new Deck();
    }


    public int Draw()
    {
        return deck.Draw();
    }

}
