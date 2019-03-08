using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackjackScript : MonoBehaviour
{
    public int bankScore;
    public int playerScore;
    public Sprite cardSprite;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void win()
    {
      if (player_score > 21) {
        console.log("Print you lost")
      } 
      elsif player_score == 21
        "Black Jack, you win!"
      elsif player_score > bank_score
        "You Win!"
      elsif player_score < bank_score
        "You Lose!"
      else
        "Push" 
    }
}
