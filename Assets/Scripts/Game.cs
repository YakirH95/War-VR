using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Game : MonoBehaviour
{
    Player player1;
    Player player2;

    public int draws;
    public GameObject table;

    private WarManager warManager;
    public GameObject Dealer;

    int player1Score;
    int player2Score;

    //create cards
    public GameObject[] Cards;

    //destroy clones only
    private GameObject player1clones;
    private GameObject player2clones;

    private soundManagerScript soundScript;
    public soundManagerScript soundManager;

    // Start is called before the first frame update
    void Start()
    {
        draws = 10;
        table = GameObject.Find("Table");


        player1Score = 0;
        player2Score = 0;

        player1 = new Player();
        player2 = new Player();

        warManager = Dealer.GetComponent<WarManager>();

        soundScript = soundManager.GetComponent<soundManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (draws == 0)
        {
            StartCoroutine ("ShowScore");
        }
    }

    public void RandomDraw()
    {
        int player1Card = player1draw();
        int player2Card = player2draw();

        if (player1Card > player2Card)
        {
            player1Score++;
            warManager.PlayerPoint();
        }

        else if (player1Card < player2Card)
        {
            player2Score++;
            warManager.RivalPoint();
        }

        else
        {

        }
    }

    int player1draw()
    {
        draws--;
        int player1Card = player1.Draw();
        player1clones = Instantiate(Cards[player1Card - 2], new Vector3(-2, -0.3f, -4), Quaternion.identity);
        soundScript.flippingCard();
        Destroy(player1clones, 2);
        return player1Card;
    }

    int player2draw()
    {
        int player2Card = player2.Draw();
        player2clones = Instantiate(Cards[player2Card - 2], new Vector3(-2, -0.3f, -2.9f), Quaternion.identity);
        Destroy(player2clones, 2);
        return player2Card;
    }

    IEnumerator ShowScore()
    {
        yield return new WaitForSeconds(2);
        table.SetActive(false);
    }
        
}
