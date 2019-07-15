using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("1: Ping-Pong, 2: Sphynx, 3: QueenCheck");

    string progChoice = Console.ReadLine();
    if(progChoice == "1"){
      PingPong();
    } else if(progChoice == "2"){
      Sphynx();
    } else if(progChoice == "3"){
      Queens();
    }
  }

  static void PingPong()
  {
    Console.WriteLine("Enter number to ping-pong to:");
    string userInput = Console.ReadLine();
    int chosenNum = int.Parse(userInput);

    for(int i = 1; i <= chosenNum; i++){
      if(i % 15 == 0){
        Console.WriteLine("Ping-Pong");
      } else if ( i % 3 == 0 ) {
        Console.WriteLine("Ping");
      } else if ( i % 5 == 0 ) {
        Console.WriteLine("Pong");
      } else {
        Console.WriteLine(i.ToString());
      }
    }
  }

  static void Sphynx()
  {
    string result = SphynxQuestions();
    Console.WriteLine(result);
    Console.ReadLine();

  }

  static string SphynxQuestions()
  {
    string win = "you survive!";
    string lose = "You died!";
    Console.WriteLine("Answer the riddles correctly to survive!");
    Console.WriteLine("What is the creature that walks on four legs in the morning, two legs at noon and three in the evening?");
    string answer1 = Console.ReadLine().ToLower();
    if(answer1 == "man"){
      Console.WriteLine("Correct...");
    } else {
      Console.WriteLine("WRONG! *The Sphynx eats you whole*");
      return lose;
    }

    Console.WriteLine("What is a man?");
    string answer2 = Console.ReadLine().ToLower();
    if(answer2 == "a miserable pile of secrets"){
      Console.WriteLine("Correct...");
    } else {
      Console.WriteLine("WRONG! *The Sphynx eats you whole*");
      return lose;
    }

    Console.WriteLine("Say yes");
    string answer3 = Console.ReadLine().ToLower();
    if(answer3 == "yes"){
      Console.WriteLine("Correct... *Sphynx commits sudoku*");
      return win;
    } else {
      Console.WriteLine("WRONG! *The Sphynx eats you whole*");
      return lose;
    }

  }

  static void Queens()
  {
    Console.WriteLine("Enter Queen Position!");
    Console.WriteLine("Queen X:");
    int queenX = int.Parse(Console.ReadLine());
    Console.WriteLine("Queen Y:");
    int queenY = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Pawn Position!");
    Console.WriteLine("Pawn X:");
    int pawnX = int.Parse(Console.ReadLine());
    Console.WriteLine("Pawn Y:");
    int pawnY = int.Parse(Console.ReadLine());
    Console.WriteLine(queenX);
    int xDiag = negativeCheck(queenX,pawnX);
    int yDiag = negativeCheck(queenY,pawnY);

    if (queenX == pawnX || queenY == pawnY || xDiag == yDiag) {
      Console.WriteLine("Queen takes Pawn!");
    } else {
      Console.WriteLine("Queen stares longingly at pawn");
    }


  }

  static int negativeCheck(int num1, int num2)
  {
    if (num1 > num2){
      return num1 - num2;
    } else {
      return num2 - num1;
    }
  }


}
