.. index:: statement; for

For-Statement Syntax
============================ 

We now introduce the last kind of loop syntax: ``for`` loops.

A ``for`` loop is an example of *syntactic sugar*:  syntax that can simplify
things for the programmer, but can be immediately translated into an
equivalent syntax by the compiler.  For example::

    for (i = 2; i <= n; i++) {
       sum = sum + i;
    }
   
is exactly equivalent to this code simliar to part of 
:ref:`SumToN <SumToN>`_::

    i= 2;
    while (i <= n) {
       sum = sum + i;
       i++;
    }

More generally:

   | ``for (`` *assignment* ``;`` *condition* ; *modification* ``)`` {
   |    statement(s)
   | ``}``
   
translates to

   | *assignment* ``;`` 
   | ``while (`` *condition* ``)`` {
   |    statement(s)
   |    *modification* 
   | ``}``

In the example above, *assignment* is ``i=2``, *condition* is ``i <= n``,
and *modification* is ``i++``.

Why bother with this rearrangement?  It is a matter of taste,
but the heading::

    for (i = 2; i <= n; i++) {
    
puts all the information about the variable controlling the loop
into one place at the top.  If you use this format, and get used to the
three parts you are less likely to forget the ``i++`` 
than when it comes tacked on to the end of a while loop body, after all 
the specific things you were trying to accomplish.  

Again: a matter of taste.


.. todo::

   Further details:

   declaration in heading

   omitting parts

   examples



..  OLD FOREACH
	
	We have already processed strings a character at a time, with ``while`` loops.
	We took advantage of the fact that strings could be indexed, and our ``while``
	loops directly controlled the sequence of indices, and then we could
	look up the character at each index::
	
		int i = 0;
		while (i < s.length) {
		   use value of s[i]...
		   i++;
		}
	
	Examples have been in :ref:`While-Sequence`, like
	
	.. literalinclude:: examples/CharLoop1.cs
	   :start-after: chunk
	   :end-before: chunk
	 
	In this example we really only care about the characters, not the indices.
	Managing the indices is just a way to get at the 
	underlying sequence of characters.
	
	A conceptually simpler view is just::
	
	   for each character in s
		   use the value of the character
		   
	To *use* "the character" in C#, we must be able to refer to it.
	We might name the current character ``ch``.
	The following is a variant of ``OneCharPerLine`` with a |for-each| 
	loop:
		static void OneCharPerLine(string s) 
		{
		   foreach (char ch in s) {
			   Console.WriteLine(ch);
		   }
		}
	
	That is all you need!   The ``foreach`` heading feeds us one
	character from ``s`` each time through, using the name ``ch`` 
	to refer to it.  
	Of course any new variable name must be declared in C#, so ``ch``
	is preceded in the heading by its type, ``char``.
	Then we can use ``ch`` inside the body of the loop.  
	Advancing to the next element in the sequence is automatic in the next 
	time through the loop.  No ``i++`` to remember; 
	no possibility of an infinite loop!
	
	The general syntax of a |for-each| loop is
	
		| ``foreach (`` **type itemName** ``in`` *sequence* ``) {``
		|      statement(s) using **itemName**
		| ``}``
	
	Here is a version of IsDigits::
	
		static Boolean IsDigits(string s) 
		{
		   foreach (char ch in s) {
			   if (ch < '0' || ch > '9') {
				  return false;
			   }
		   }
		   return (s.Length > 0);
		}
	
	See the advantages of ``foreach`` in these examples:
	- They are more concise than the indexing versions.
	- They keep the emphasis on the characters, not the secondary indicies.
	- The ``foreach`` heading emphasizes that a particular sequence is being 
	  processed.
	  
	*If* you have explicit need to refer to the indices of the items in the sequence,
	then this pattern does not work.  You can use a ``while`` loop, or perhaps a
	``for`` loop, introduced soon....
