using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackjackScript : MonoBehaviour
{
    public int bankScore;
    public int playerScore = 0;
    public Sprite cardSprite;
    public GameObject teste;
    // Sortear numero randomico p/ bankScore (16-21)
    var r = new Random();
    // int n = r.Next(-5, 5);
    

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

     // switch (playerScore)
		   //  {
		   //      case DayOfWeek.Sunday:
		   //          Console.WriteLine("dies Solis");
		   //          break;

		   //      case DayOfWeek.Monday:
		   //          Console.WriteLine("dies Lunae");
		   //          break;                    

		   //      case DayOfWeek.Tuesday:
		   //          Console.WriteLine("dies Martis");
		   //          break;                    

		   //      case DayOfWeek.Wednesday:
		   //          Console.WriteLine("dies Mercurii");
		   //          break;                    

		   //      case DayOfWeek.Thursday:
		   //          Console.WriteLine("dies Jovis");
		   //          break;                    

		   //      case DayOfWeek.Friday:
		   //          Console.WriteLine("dies Veneris");
		   //          break;

		   //      case DayOfWeek.Saturday:
		   //          Console.WriteLine("dies Saturni");
		   //          break;
		   //  }
    }
}
