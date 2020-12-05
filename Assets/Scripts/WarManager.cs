using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarManager : MonoBehaviour
{
    public Text PlayerScoretxt;
    public Text RivalScoretxt;

   public int PlayerScore = 0;
   public int RivalScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        PlayerScoretxt.text = PlayerScore.ToString();
        RivalScoretxt.text = RivalScore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerPoint()
    {
        PlayerScore += 1;
        PlayerScoretxt.text = PlayerScore.ToString();
    }

    public void RivalPoint()
    {
        RivalScore += 1;
        RivalScoretxt.text = RivalScore.ToString();
    }
}
