.. index::
   triple:  while; index; sequence

.. _While-Sequence:


While-Statements with Sequences
================================= 

We will process many sequences or collections.  At this point
the only collection we have discussed is a string - a sequence of
characters that we can index.

Consider the following silly function description and heading as a start:

.. literalinclude:: examples/CharLoop1.cs
   :start-after: chunk
   :end-before: {
 
``OneCharPerLine("bug")`` would print:

  | b
  | u
  | g

We are accessing one character at a time.  We can do that with
the indexing notation.  Thinking concretely about the example above,
we are looking to print, ``s[0]``, ``s[1]``, ``s[2]``.
This requires a loop.  
For now our only option is a ``while`` loop.  We can follow 
our basic rubric, one step at a time:
The index is changing in a simple repetitive sequence.  
We can call the
index ``i``.  Its intitial value is clearly 0. 
That is our initialization.  We need a ``while`` loop continuation 
condition.
For the 3-character string example, the last index above is 2.
In general we want *all* the characters.  Recall the index of the last 
character is the length - 1, or with our parameter``s``, ``s.length - 1``
The ``while`` loop condition needs to allow indices through 
``s.length - 1``.  We could write a condition with ``<=`` or more
concisely::

    while (i < s.length) {

In the bode of the loop, the main thing is to print the next character,
and the next character is ``s[i]``::

    Console.WriteLine(s[i]);
    
We also need to remember the part to get ready for the next time 
through the loop.  We have dealt with regular sequence of values
before.  We change ``i`` with::

    i = i+1;
    
This change is so common, there is a simpler syntax::

    i++;
    
This increases the value of the numeric variable i by 1.
(The reverse is ``i--;``)

So all together:

.. literalinclude:: examples/CharLoop1.cs
   :start-after: chunk
   :end-before: chunk
 
You can test this with example :file:`CharLoop1.cs``.

This is a very common pattern.  
We could do anything we want with each individual character, 
no just print it.

Let us get more complicated.  Consider the function described:

.. literalinclude:: examples/Vowels.cs
   :start-after: chunk
   :end-before: {

For instance PrintVowels("hello") would print:

    | e
    | o

We have seen that we can go through the whole string and do the same
thing each time through the loop, use ``s[i]`` in some specific way.

This new description seems like a problem.  We do *not* appear to want to do
the same thing each time:  We only want to print *some* of the 
characters.  Again your eyes and mind are so fast, you likely miss what you
need to do when go through ``PrintVowels`` by hand.  Your
eyes let you just grab the vowels easily, but think, wht is actually
happening?  You are checking each character to see if it is a vowel,
and printing it if it is:  You are doing the same thing each time -
*testing* **if** the character is a vowel.  The pseudocode is   ::

    if (s[i] is a vowel) {
       print s[i]
    }

We do want to do this each time through the loop.  We *can* use 
a ``while`` statement.

Next problem:  convert the pseudocode "s[i] is a vowel" to C#.

To be continued....


Next problem after this one:  see if a string contains only digits.