using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackjackScript : MonoBehaviour
{
    public int bankScore;
    public int playerScore = 0;
    public Sprite cardSprite;
    
    // Sortear numero randomico p/ bankScore (16-21)

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void win()
    {
      if (playerScore > 21) {
        print("Print you lost");
      } else if (playerScore == 21) {
        print("Black Jack, you win!");
      } else if (playerScore > bankScore) {
        print("You Win!");
      } else if (playerScore < bankScore) {
        print("You Lose!");
      } else {
        print("Push"); 
      }
    }
}
