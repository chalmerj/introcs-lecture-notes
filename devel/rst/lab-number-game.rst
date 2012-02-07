.. index::
   single: labs; string manipulations

.. _lab-number-game:

Number Guessing Game Lab
========================

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
steps. You'll start by writing a program to do the following:

#. Prompt the user for the minimum and maximum values:

   | Enter a minimum number (min): **1**
   | Enter a maximum number (max): **100**
 
#. The program is basically "pretending" to be Person A. It begins by
   computing a secret number, using a technique known as random-number
   generation. For your convenience, we are going to give you the C#
   code to compute the random number::

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

Now we will expand the above solution to support the "higher or lower"
aspect of the number guessing game.

You'll have to make the following modifications:

#. Declare two variables ``upper`` and ``lower``. Before entering the
   loop to guess the number, you need to set ``upper=max`` and
   ``lower=min``. We will adjust these two variables *within the
   loop* based on the guess.

#. If the guess is higher than the secret number, this means that we
   have a new low value.  For example, if the secret number is 29 and
   you guessed 15, this means that 15 would become the new *lower
   bound* on the guess.

#. If the guess is lower than the secret number, this means that we
   have a new high value. For example, if the secret number is 29 and
   you guessed 40, this means that 40 is the new *upper bound*.


Other Possible Improvements or Variations
-----------------------------------------

Should you finish everything early, try the following:

#. Use an outer ``while`` loop to allow the game to be played
   repeatedly. There could be a prompt to ask the user whether he/she
   wants to play again. If the user says, no, the loop would
   terminate.

#. Add another hint to help the user solve the problem. For example,
   if the randomly generated secret number is even, you can tell the
   user (upon his/her first guess) that the number is even (and
   whether it's higher or lower). This would make it easier for the
   user to guess the number.

#. Revise the program so that the user is the one who knows the secret
   number and the computer guesses higher and lower until the answer
   is obtained. The program will tell the user to put a number in
   his/her head. Within the loop, the computer will make random
   guesses within ``lower`` and ``upper`` and adjust these bounds
   based on whether the human user says higher or lower after the
   program shows what it thinks the secret number is on the
   screen. The computer will also be able to detect whether the human
   user is telling the truth about the number (in the case where
   ``lower`` and ``higher`` bump into one another.

