.. _lab-number-game

.. index::
   single: labs; string manipulations

Lab: Number Guessing Game
=========================

This lab is inspired by a famous game played by children (and grown-ups,
too) known as the number-guessing game. It is often played by two
people but could be played by any number of people.

The rules are:

- Person A chooses a number between 1 and N and keeps it in his or
  her head.

- Person B makes repeated guesses to determine the number. Person A
  must indicate whether the guess is higher or lower.

- Person A must tell the truth.

So as an example:

- George and Andy are playing the game.

- George chooses a number between 1 and 100 (29) and puts it in his
  head.

- Andy guesses 50. George says "Lower". Andy now knows that the number
  is between 1 and 50.

- Andy guesses 25. George says "Higher". Andy now knows that the number
  is between 25 and 50.

- Andy guesses 30. George says "Lower". Andy now knows that the
  number is between 25 and 30.

- Andy starts thinking he is close to knowing the correct answer. He
  decides to guess 29. Andy guesses the correct number. So George
  says, "Good job! You win."



Part 1: Guessing Indefinitely without Hints
-------------------------------------------

So to create this game, we are going to start by taking some baby
steps.

#. Prompt the user for the minimum and maximum values:

   | Enter a minimum number (min): **1**
   | Enter a maximum number (max): **100**
 
#. The program begins by computing a secret number, using a technique
   known as random-number generation. For your convenience, we are
   going to give you the C# code to compute the random number::

      Random r = new Random();
      int randomNumber = r.Next(min, max);

   In case you are wondering, we are using a *class* in C# to create a
   random number generator. We'll cover this in more detail when we
   get to the Classes and Objects section. Here is what hap

      csharp> Random r = new Random();
      csharp> int randomNumber = r.Next(min, max);
      csharp> r.Next(1, 100);   
      52
      csharp> r.Next(1, 100); 
      97
      csharp> r.Next(1, 100); 
      61
      csharp> r.Next(1, 100); 
      96
      csharp> r.Next(1, 100); 

   You can see that r.Next() is smart enough to give what appears to
   be a different number every time. If you call it 100 times, it is
   likely that you'll see the same number twice!


#. Write a loop that prompts the user for a guess until the randomly
   generated number and the guess match. Here is a sketch of how the
   code might work::

       // Prompt user for min and max as in step 1.

       // generate a random number 
       Random r = new Random();
       int secretNumber = r.Next(min, max)

       do {
       
          // Prompt user for a guess (guessNumber)

       while (guessNumber != secretNumber);


#. If you like, you can keep a count (numberOfGuesses) in the loop to
   let the user know how many guesses were required to guess the
   secret (secretNumber).


Part 2: Higher or Lower?
------------------------

#. Do it with programmer set secret number, and simplify - no hints on too large or small

#. Count tries and end with something like: Correct  after 4 guesses!

#. Add hints when wrong too large or small

#. make a random choice of secret number, say in range 1 - 10 ( need
   new syntax introduced) If an object is needed, I suggest syntax is
   given for it to be automatically created as a static variable
   static randomGenerator = new ???? ; Then it can be used in Game.

#. Make Game have a parameter for the largest possible secret number
   (set in the call in Main).  For now set with an explicit number.

#. In Main, have the user be prompted and choose how hard to make the
   game (replacing your explicit number in the previous version).

#. Let the user play the game many times in the same program.  Change
   the prompt in Main to "Choose the largest possible secret number (0
   to quit): " and make the program do what you say, repeating Game
   until the user enters 0.
