.. _Multiple-Function-Definitions:

Multiple Function Definitions
==============================

Here is example program ``birthday3.cs`` where we add a function
``happyBirthdayAndre``, and call them both. Guess what happens, and
then load and try it:

.. literalinclude:: examples/birthday3.cs

Again, definitions are remembered and execution starts in ``Main``.  
The order in which the function definitions are given does not matter
to C#.  It is a human choice.  For variety I show ``Main`` first.  This 
means a human reading in order gets an overview of what is happening 
by looking at Main, but does not know the details until reading the 
definitions of the birthday functions.

Detailed order of execution:

#. Line 5: Start on ``Main``

#. Line 7. This location is remembered as execution jumps to
   ``happyBirthdayEmily``

#. Lines 11-17 are executed and Emily is sung to.

#. Return to the end of Line 7: Back from ``happyBirthdayEmily``
   function call

#. Line 8: Now ``happyBirthdayAndre`` is called as this location is
   remembered.

#. Lines 19-25: Sing to Andre

#. Return to the end of line 8: Back from ``happyBirthdayAndre``
   function call, done with ``Main``; 
   at the end of the program


The calls to the birthday functions
*happen* to be in the same order as their definitions, but that is
arbitrary. If the two lines of the body of ``Main`` were swapped, 
the order of
operations would change. 

Functions that you write can also call other functions you write.
In this case Main calls each of the birthday functions.

Poem Function Exercise
-------------------------

Write a program, :file:`poem.cs`, that defines a function that
prints a *short* poem or song verse. Give a meaningful name to the
function. Have the program call the function three times,
so the poem or verse is repeated three times.

	
See :ref:`BirthdayFunctionEx`.

We can combine function parameters with user input, and have the
program be able to print Happy Birthday for anyone. Check out the
main method and run ``birthday_who.cs``:

.. literalinclude:: examples/birthday_who.cs
   :linenos:

This last version illustrates several important ideas:

#. There are more than one way to get information into a function:
   
   #. Have a value passed in through a parameter (from line 10 to line 3).

   #. Prompt the user, and obtain data from the keyboard (line 11).

#. It is a good idea to separate the *internal* processing of data
   from the *external* input from the user by the use of distinct
   functions. Here the user interaction is in ``main``, and the data
   is manipulated in ``happyBirthday``.

#. In the first examples of actual parameters, we used literal
   values. In general an actual parameter can be an expression. The
   expression is evaluated before it is passed in the function call.
   One of the simplest expressions is a plain variable name, which is
   evaluated by replacing it with its associated value. Since it is
   only the value of the actual parameter that is passed, not any
   variable name, there is *no need* to have a variable name used in
   an actual parameter match a formal parameter name. (Here we have the
   value of ``userName`` in ``main`` becoming the value of ``person``
   in ``happyBirthday``.)

