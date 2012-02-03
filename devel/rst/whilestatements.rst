.. index::
   double:  while; statement

.. _While-Statements:


While-Statements
============================ 


.. _Simple-while-Loops:
   
Simple ``while`` Loops
----------------------

We have seen that the sequential flow of a program 
can be altered with function calls
and decisions.  The last important pattern is *repetition* or *loops*.
There are several varieties.  The simplest place to start is with
``while`` loops.

A C#
``while`` loop behaves quite similarly to common English usage. If
I say

    While your tea is too hot, add a chip of ice.

Presumably you would test your tea. If it were too hot, you would
add a little ice. If you test again and it is still too hot, you
would add ice again. *As long as* you tested and found it was true
that your tea was too hot, you would go back and add more ice.
C# has a similar syntax:

    | ``while (`` *condition* ``)`` 
    |   statement 

As with an ``if`` statement we will generally assume a compound statement, 
after the condition, so the syntax will actually be:

    | ``while (`` *condition* ``) {`` 
    |    statement(s)
    | ``}``

Setting up the English example in a similar format would be:

    | while  ( *your tea is too hot* ) { 
    |     add a chip of ice 
    | }

To make things concrete and numerical, suppose the following: The
tea starts at 115 degrees Fahrenheit. You want it at 112 degrees. A
chip of ice turns out to lower the temperature one degree each
time. You test the temperature each time, and also print out the
temperature before reducing the temperature. In C# you could
write and run the code below, saved in example program Cool.cs:

.. literalinclude:: examples/Cool.cs
   :start-after: chunk
   :end-before: chunk
   :linenos:

I added a final line after the ``while`` loop to remind you that
execution follows sequentially after a loop completes.

It is extremely important to totally understand how the flow of
execution works with loops.  One way to follow it
closely is to make a table with a line for each instruction
executed, keeping track of all the variables.  We call this
*playing computer*.

Each row show the line number of the start of the next instruction
executed, and the values of all the variables *after* the instruction
is executed.  The important thing to see with loops is that the same
lline can be executed over and over, but with different variable
values.  We leave a column for the line number, each variable
that is involved (particularly any that change) and a place for
comments about what is happening.

If you play computer and follow the path of execution, you could
generate the following table. Remember, that each time you reach
the end of the block after the ``while`` heading,
execution returns to the ``while`` heading for another test:

====  ===========  =======
Line  temperature  Comment
====  ===========  =======
1     115
2                  115 > 112 is true, do loop
3                  prints 115
4     114          115 - 1 is 114, loop back
2                  114 > 112 is true, do loop
3                  prints 114
4     113          114 - 1 is 113, loop back
2                  113 > 112 is true, do loop
3                  prints 113
4     112          113 - 1 is 112, loop back
2                  112 > 112 is false, skip loop
6                  prints that the tea is cool
====  ===========  =======

Each time the end of the loop body block is reached, execution
returns to the ``while`` loop heading for another test. When the
test is finally false, execution jumps past the indented body of
the ``while`` loop to the next sequential statement.

The biggest trick with a loop is to make the same code do the next
thing you want each time through.  That generally involves 
the use of variables that are modified for each successive time through
the loop.  

    | initialization
    | ``while (`` *continuationCondition* ``) {`` 
    |     do main action to be repeated 
    |     prepare variables for the next time through the loop
    | ``}``
    
The simple first example follows this pattern directly.  Note
that the variables needed for the test of the condition must be
set up *both* in the initialization *and* inside the loop
(often at the very end).  Without a change inside the loop, the loop would
run forever!

It is a big deal for beginning students, how to manage all this in general.
We will see a number of common patterns in lots of practice.  We will use
the term *successive modification loop* for loops following this pattern.

Test yourself: Following the code.  Figure out what is printed.
If it helps, get detailed and play computer:

.. literalinclude:: examples/TestWhile1.cs
   :start-after: chunk
   :end-before: chunk
   :linenos:

Check yourself by running the example program ``TestWhile1.cs``.

.. note::
   In C#, ``while`` is not used *quite* like in English. In
   English you could mean to stop *as soon as* the condition you want
   to test becomes false. In C# the test is *only* made when
   execution for the loop starts (or starts again), 
   *not* in the middle of the loop.

*Predict* what will happen with this slight variation on the
previous example, switching the order in the loop body. Follow it
carefully, one step at a time.

.. literalinclude:: examples/TestWhile2.cs
   :start-after: chunk
   :end-before: chunk
   :linenos:

Check yourself by running the example program ``TestWhile2.cs``.

The sequence order is important. The variable ``i`` is increased before
it is printed, so the first number printed is 6. Another common
error is to assume that 10 will *not* be printed, since 10 is
*past* 9, but the test that may stop the loop is *not* made in the
middle of the loop. Once the body of the loop is started, it
continues to the end, even when ``i`` becomes 10.
 
====  ==  ======= 
Line   i  Comment
====  ==  ======= 
1      4
2         4 < 9 is true, do loop
3      6  4+2=6
4         print 6
2         6 < 9 is true, do loop
3      8  6+2= 8
4         print 8
2         8 < 9 is true, do loop
3     10  8+2=10  *No test here*
4         print 10 
2         10 < 9 is false, skip loop
====  ==  ======= 

**Problem**:  Write a program with a ``while`` loop to print::

    10
    9
    8
    7
    6
    5
    4
    3
    2
    1
    Blastoff!

**Analysis**:  
We have seen that we can produce a regular sequence of numbers in a loop.
The "Blastoff!" part does not fit the pattern, so it must be a *separate*
part after the loop.  We need a name for the number that decreases.  It can
be ``time``.  Remember the general rubrick for a ``while`` loop:

    | initialization
    | ``while (`` *continuationCondition* ``) {`` 
    |     do main action to be repeated 
    |     prepare variables for the next time through the loop
    | ``}``

You can consider each part separately.  Where to start is partly a 
matter of taste.

The main thing to do is print the time over and over.
The inital value of the time is 10.  We are going to want to keep printing 
until the time is down to 1, so we *continue* while the time is at least 1,
meaning the continuationCondition can be ``time >= 1``, 
or we could use ``time > 0``.

Finally we need to get ready to print a different time in 
the next pass through the loop.
Since each successive time is one less than the previous one, the
preparation for the next value of time is:  ``time = time - 1``.

Putting that all together, and remembering the one thing we noted 
to do after the loop,
we get ``Blastoff.cs``:

.. literalinclude:: examples/Blastoff.cs

Look back and see how we fit the general rubrick.  
There are a bunch of things to think about with a while loop, so
going one step at a time, thinking of the rubrick and the specific
needs of the current problem, helps.

There are many different (and more exciting) patterns of change coming
for loops, 
but the simple examples so far get us started.

Looking ahead to more complicated and interesting problems,
here is a more complete list of questions to ask yourself when
designing a function with a ``while`` loop:

-  What variables do I need?
-  What needs to be initialized and how? This certainly includes any
   variable tested in the condition.
-  What is the condition that will allow the loop to continue?
-  What is the code that should only be executed once? What action do I want to
   repeat? Where does the repetition come in the overall sequence of
   operations?
-  How do I write the action so I can modify it for the next time
   through the loop?
-  What code is needed to do modifications to make the same code work
   the next time through the loop?
-  Have I thought of variables needed in the middle and declared them;
   do other things need initialization?
-  Will the continuation condition enventually fail?
-  Separate thing to be done once before the repetition (code before the
   loop) from repetitive actions (in loop) from actions not repeated but
   done after the loop (code after the loop). Missing this distinction
   is a *common error*!


.. rubrick:: Sum To ``n``

Let us write a function to sum the numbers from 1 to ``n``::

    /** Return the sum of the numbers from 1 through n. */
    static int SumToN(int n) 
    {
       ...
    }

For instance SumToN(5) calculates 1 + 2 + 3 + 4 + 5 and returns 15.
We know how to generate a sequence of integers, but this is a place
that a programmer gets tripped up by the speed of the human mind.  
You are likely
so quick at this that you just see it all at once, with the answer.

In fact, you and the computer need to do this in steps.  To help see, let
us take a concrete example like the one above for SumToN(5), and write out a 
detailed sequence of steps like::

    3 = 1 + 2
    6 = 3 + 3 
    10 = 6 + 4
    15 = 10 + 5
    
You could put this in code directly for a specific sum, but if n is general,
we need a loop, and hence we must see a pattern in code that we can repeat.

Each of the second terms in the additions is a successive integer, 
that we can generate.  Starting in the second line, the first number
in each addition
is the sum from the previous line.  Of course the next integer and the next
partial sum change from step to step, so in order to use the same code over and
over we will need changeable variables, with names.  We can make the partial
sum be ``sum`` and we can call the next integer ``i``.  Each addition can be
in the form::

    sum + i

We need to remember that result, the new sum.  you might first think to introduce
such a name::

    newSum = sum + i;
    
This will work.  We can go through the ``while`` loop rubrick:
    
The variables are ``sum``, ``newSum`` and ``i``.
    
To evaluate 

    newSum = sum + i;

the first time in the loop, we need *initial* values for sum and i.
Our concrete example leads the way::

   int sum = 1, i = 2;
   
We need a ``while`` loop heading with a continuation condition.  How
long do we want to add the next ``i``?  That is for all the value up to and
including n::

   while (i <= n) {

There is one more important piece - making sure the same code 

    newSum = sum + i;
    
works for the *next* time through the loop.  We have dealt before with
the idea of the next number in sequence::

   i = i + 1;
   
What about ``sum``?  What was the ``newSum`` on one line becomes the old or
just plain ``sum`` on the next line, so we can make an assignment::

   sum = newSum:
   
All together we calculate the sum with::

   int sum = 1, i = 2;
   while (i <= n) {
      newSum = sum + i;
      i = i + 1;
      sum = newSum:
   }
   
This exactly follows our general rubrick, with preparation for the next time
through the loop at the end of the loop.  
We can condense it in this case, since ``newSum`` is only used
once, we can do away with it, and directly change the value of sum::

   int sum = 1, i = 2;
   while (i <= n) {
      sum = sum + i;
      i = i + 1;
   }

Finally this was supposed to fit in a function.  The ultimate purpose
was to *return* the sum, which is the final value of the
variable ``sum``, so the whole function is::

  /** Return the sum of the numbers from 1 through n. */
  static int SumToN(int n) 
  {
     int sum = 1, i = 2;
     while (i <= n) {
        sum = sum + i;
        i = i + 1;
     }
     return sum;
  }

The comment before the function definition does not give a clear idea of the 
range of possible values for n.  How small makes sense for the comment?
What actuyally works in the function?  The smallest expression 
starting with 1 would just be 1: (n = 1).  Does that work in the function?
You were probably not thinking of that when developing the function!
Now look back now at this *edge case*.  You can play computer on the code
or directly test it.  In this case the initialization of ``sum`` is 1,
and the body of the loop *never* runs (2 <= 1 is false).  The function
moves right to the return statement, and
does return 1, and everything is fine.

Now about large n....

With loops we can make programs run for a long time.
The time taken becomes an issue.  In this case we go though the loop
close to n times, so the total time is approximately proportional to n.
We write that the time is O(n), spoken "oh of n", or "big oh of n" or
"order of n".

Computers are pretty fast, so you can try the testing program 
``SumToNTest.cs``
and it will go by so fast, that you will hardly notice.  Try these specific
numbers in tests: 5, 6, 1000, 10000, 98765.  All look OK?  Now try 66000.
On many systems you will get quite a surprise!  
This is the first place we have to deal with the limited 
size of the ``int`` type.
On many systems the limit is a bit over 2 billion.  
(You can check out the size of ``int.MaxValue`` in csharp.)
The answer for 66000,
and *also* 98765, is bigger.  Luckily the obviously wrong negative answer
for 66000 pops out at you.  Did you guess before you saw the answer for
66000, that there was an issue for 
98765?  It is a good thing that no safety component in a big bridge was being 
calculated!  It is a big deal that the system fails *silently* 
in such situations.  *Think* how large the data may be that you deal with!

Now look at, compile, and run ``SumToNLong.cs``.  The sum is
a ``long`` integer here. Check out in csharp how big
a ``long`` can be (``long.MaxValue``).  This version of the program
works for 100000 and for 98765.  We can get correct
answers for things that will take perceptible time.  Try working up to 
1 billion (1000000000, nine 0's).  It takes a while: O(n) can be slow!

By hand it is a lot slower, unless you totally hange the algorithm:
There is a classic story about how a calculation like this
was done in gradeschool (n=100) by the famous
mathematician Gauss. His teacher was trying to keep him busy.
Gauss discovered the general, exact, mathematical formula:  
    
    1 + 2 + 3 + ... + n = n(n+1)/2.  
    
That is the number of terms (n), times the average term (n+1)/2.

Our loop was instructive, but not the fastest approach.  The simple exact
formula takes about the same time for any n.  
(That is as long as the result fits in
a standard type of computer integer!)  
This is basically constant time.  In discussing
how the speed relates to the size of n, we say it is O(1). 
The point is here that 1 is a constant.  The time is of *constant order*.

*Working* and being *efficient* are two different things in general.  

On to some truly useful loops....

..  later

	.. index::
	   triple: interactive; loop; while
	
	   
	.. _Interactive-while-Loops:
		
	Interactive ``while`` Loops
	---------------------------
	
	The earlier examples of while loops were chosen for their
	simplicity. Obviously they could have been rewritten with range
	function calls. Now lets try a more interesting example. Suppose
	you want to let a user enter a sequence of lines of text, and want
	to remember each line in a list. This could easily be done with a
	simple repeat loop if you knew the number of lines to enter. For
	example, in ``readLines0.cs``, the user is prompted for the exact
	number of lines to be entered:
	
	.. literalinclude:: examples/readLines0.cs
	   :lines: 3-
	
	The user may want to enter a bunch of lines and not count them all
	ahead of time. This means the number of repetitions would not be
	known ahead of time. A ``while`` loop is appropriate here. There is
	still the question of how to test whether the user wants to
	continue. An obvious but verbose way to do this is to ask before
	every line if the user wants to continue, as shown below and in the
	example file ``readLines1.cs``. Read it and then run it:
	
	.. literalinclude:: examples/readLines1.cs
	   :lines: 3-
	
	See the *two* statements setting ``testAnswer``:  
	one before the ``while`` loop and one at the bottom of the loop body.
	
	.. note::
	   The data must be initialized *before* the loop, in order for the
	   first test of the while condition to work. Also the test must work
	   when you loop back from the end of the loop body. This means the
	   data for the test must also be set up a second time, *in* the loop
	   body.  It is easy to forget the second time!
	
	The ``readLines1.cs`` code works, but it may be more annoying than
	counting ahead! Two lines must be entered for every one you
	actually want! A practical alternative is to use a *sentinel*: a
	piece of data that would *not* make sense in the regular sequence,
	and which is used to indicate the *end* of the input. You could
	agree to use the line ``DONE!`` Even simpler: if you assume all the
	real lines of data will actually have some text on them, use an
	*empty* line as a sentinel. (If you think about it, the C#
	Shell uses this approach when you enter a statement with an
	indented body.) This way you only need to enter one extra (very
	simple) line, no matter how many lines of real data you have.
	
	What should the while condition be now? Since the sentinel is an
	empty line, you might think ``line == ''``, but that is the
	*termination* condition, not the *continuation* condition: You need
	the *opposite* condition. To negate a condition in C#, you may
	use ``not``, like in English,  ::
	
		not line == ''
	
	Of course in this situation there is a shorter way, ::
	
		line != ''
		
	Run the example program ``readLines2.cs``, shown below:
	
	.. literalinclude:: examples/readLines2.cs
	   :lines: 3-
	
	Again the data for the test in the while loop heading must be
	initialized before the first time the ``while`` statement is
	executed and the test data must *also* be made ready inside the
	loop for the test after the body has executed. Hence you see the
	statements setting the variable ``line`` both before the loop and
	at the end of the loop body. It is easy to forget the second place
	inside the loop!
	
	*After* reading the rest of this paragraph,
	comment the last line of the loop out, and run it again:
	It will never stop! The
	variable ``line`` will forever have the initial value you gave it!
	You actually can stop the program by entering :kbd:`Ctrl-C`. That means
	hold the :kbd:`Ctrl` key and press :kbd:`c`.
	
	.. note::
	   As you finish coding a ``while`` loop, it is good practice to
	   always double-check: Did I make a change to the variables, *inside*
	   the loop, that will eventually make the loop condition ``False``?
	
	The earliest ``while`` loop examples had numerical tests and the code
	to get ready for the next loop just incremented a numerical variable
	by a fixed amount.  Those were simple examples but ``while`` loops
	are much more general!  In the interactive loop we have seen a continuation
	condition with a string test, and getting ready for the next time through
	the loop involves input from the user.
	
	Some of the exercises that follow involve interactive while loops.
	Others were delayed until here just because they have a wider variety of
	continuation condition tests and ways to prepare for the next time through
	the loop.  What is *consistent* is the general steps to think of and
	questions to ask yourself.  They keep on applying!  Keep these in mind!
	
	  * the need to see whether there *is* a kind of
		repetition, even without a fixed collection of values to work through
	
	  * to think from the specific situation and figure out the
		continuation condition that makes sense for your loop
	
	  * to think what specific processing or results you want each time through
		the loop, using the *same* code
	
	  * to figure out what supporting code you need to make you ready for the
		next time through the loop:  how to make the *same* results code
		have *new* data values to process each time through, and eventually reach
		a stopping point.
		
	
	.. _interactive-sumEx:
		
	Interactive Sum Exercise
	~~~~~~~~~~~~~~~~~~~~~~~~
	
	Write a program ``sumAll.cs`` that prompts the user to enter
	numbers, one per line, ending with a line containing 0, and keep a
	running sum of the numbers. Only print out the sum after all the
	numbers are entered (at least in your *final* version).
	Do *not* create a list!  Each time you read in a number, you can
	immediately use it for your sum, and then be done with the number
	just entered.
	
	.. _Safe-Num-Input-Ex:
	
	Safe Number Input Exercise
	~~~~~~~~~~~~~~~~~~~~~~~~~~
	
	\* There is an issue with reading in numbers with the input statement.
	If you make a typo and enter something that cannot be converted from a
	string to the right kind of number, a naive program will bomb.
	This is avoidable if you test the string and repeat if the string is illegal.
	In this exercise write safe utility function replacements
	for the input function that work to read in a whole number, an integer or
	a decimal number.
	
	All parts refer to the previous
	:ref:`Is-Number-String-Ex`.  Part a. refers to the introduction in the
	previous exercise.
	Parts b. and c. refer to functions in the solution, ``isNumberStr.cs``, of
	the previous exercise.
	Make sure you look back at these first.
	
	Save the example ``safeNumberInputStub.cs`` as ``safeNumberInput.cs``,
	and complete it.
	It contains headings and documentation strings
	for the functions in each part of this exercise.
	
	a.  This part considers the simplest case,
		where you are trying to enter a whole number.
		Complete the definition of the function ``safeWholeNumber``.
	
	b.  Complete the function ``safeInt``.  This easily parallels part a.
		if you copy in and use the function (not method) ``isIntegerStr``.
	
	c.  Complete the function ``safeDecimal``.  This easily parallels part b.
		if you copy in and use the function ``isDecimalStr``.
	
	Savings Exercise
	~~~~~~~~~~~~~~~~
	
	The idea here is to see how many years it will take a bank account to grow
	to at least a given value, assuming a fixed annual interest.
	Write a program ``savings.cs``.
	Prompts the user for three numbers: an initial balance, the annual percentage
	for interest as a decimal. like .04 for 4%, and the final balance desired.
	Print the initial balance, and the balance each year until
	the desired amount is reached. Round displayed amounts
	to two decimal places, as usual.
	
	The math:  The amount next year is the amount now times
	(1 + interest fraction),
	so if I have $500 now and the interest rate is .04,
	I have $500*(1.04) = $520 after one year and after two years I have,
	$520*(1.04) = $540.80.
	If I enter into the program a $500 starting balance, .04 interest rate and
	a target of $550, the program prints::
	
	   500.00
	   520.00
	   540.80
	   563.42
	
	.. _Strange-Seq-Ex:   
	
	Strange Sequence Exercise
	~~~~~~~~~~~~~~~~~~~~~~~~~
	
	\* Recall :ref:`Strange-Func-Ex` and its ``jumpFunc.cs`` 
	which contains the function ``jump``:
	For any integer n, jump(n) is n//2 if n is even, and 3*n+1 if n is odd.
	
	You can start with one number, say n = 3, and *keep* applying the
	jump function to the *last* number given, and see how the numbers jump around!
	::
	
		jump(3) = 3*3+1 = 10; jump(10) = 10//2 = 5;
		jump(5) = 3*5+1 = 16; jump(16) = 16//2 = 8;
		jump(8) = 8//2 = 4; jump(4) = 4//2 = 2;
		jump(2) = 2//2 = 1
	
	This process of repeatedly applying the same function to the most recent result
	is called function *iteration*.  In this case you see that iterating the
	jump function, starting from n=3, eventually reaches the value 1.
	
	It is an open research question whether iterating the jump function
	from an integer n will eventually reach 1,
	for *every* starting integer n greater than 1.
	Researchers have only found examples of n where it is true.
	Still, no general argument has been made to apply to the
	*infinite* number of possible starting integers.
	
	In this exercise you iterate the jump function for specific
	starting values n, until the result is 1.
	
	a.  Save example ``jumpSeqStub.cs`` as ``jumpSeq.cs`` and complete the missing
		function bodies.  If you coded the function ``jump`` before in
		``jumpFunc.cs``, you can copy it.
		You can complete either ``printJumps`` or
		``listJumps`` first, and test before completing the other. Hint [#]_
	
	
	b.  After you have finished and saved ``jumpSeq.cs`` copy it and save
		the file as ``jumpSeqLengths.cs``.
	
		First modify the main method so it prompts the user
		for a value of n, and then prints just the length of the iterative sequence
		from listJumps(n).  Hint [#]_
	
		Then elaborate the program so it prompts the user for two integers:
		a lowest starting value of n
		and a highest starting value of n.
		For all integers n in the range from the lowest start through
		the highest start, including the highest,
		print a sentence giving the starting value of n
		and the length of the list from ``listJumps(n)``.  An example run::
	
			Enter lowest start: 3
			Enter highest start: 6
			Starting from 3, jump sequence length 8.
			Starting from 4, jump sequence length 3.
			Starting from 5, jump sequence length 6.
			Starting from 6, jump sequence length 9.
		
	
	
	
