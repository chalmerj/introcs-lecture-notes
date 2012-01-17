Lab Exercise: Editing, Compiling, and Running
---------------------------------------------

Summary
~~~~~~~

This first lab is aimed at taking you through the end-to-end process of
writing and running a basic computer program. As with all things in
life, we will learn in this lab that becoming a programmer requires you
to learn a number of other things.

In software development/engineering parlance, we typically describe a
scenario as a *workflow*, which can be thought of as a series of steps
that are possibly repeated. The workflow of programming can loosely be
defined as follows:

1. Use a text editor to write your source code (human readable).
2. Compile your code using the Software Development Kit (SDK) into
   object code.
3. Link your object code to create an executable. (There are other kinds
   of results to produce, 
   but we will start with the idea of an executable program
   to keep things simple.)  The default is to
   nave an executable program created with compilation, automatically. 
4. Run your program. Even for the most seasoned developers, your program
   may not work entirely right the first time, so you may end up
   repeating these steps (debugging).

..  what is this?
	.. raw:: html
	
	   <!~~ end of list ~~>

As we will learn later in the course, development environments such as
Visual Studio (from Microsoft) and MonoDevelop (an open source
implementation similar to Visual Studio) basically shield you from the
details of understanding the workflow in detail. We think it is
important that you *learn* this workflow from day one, because many types
of software development don't always have the easiest software
development tools.  You will be able to use fancy tools later.

To be completed in the lab
~~~~~~~~~~~~~~~~~~~~~~~~~~

The following is the code for a very well-known program, *Hello,
World!*:

.. literalinclude:: hello+nant/HelloWorld.cs
   :language: csharp
   :emphasize-lines: 9
   :linenos:

This program is deliberately simple, so you can type it into a text
editor (we are assuming Emacs here) quickly and become familiar with how
to create, edit, and save a program. Perform the following steps. (You
are free to deviate but may want to consider following the steps
religiously at least once to ensure you were successful.)

1.  Open the Emacs text editor. This can usually be done from your GUI's
    start menu.

2.  Create a folder anywhere you like (e.g. in Documents) and name it
    ``hello``. (This can be done through the desktop shell (e.g. Windows
    Explorer or Apple Finder.) As a general rule, we recommend that you
    start any new programming project in its own folder that is free of
    other folders/files. Clutter is a great enemy of those who aspire to
    become good programmers.

3.  When you start in Emacs, you are in what is known as *scratch* mode.
    Typical of a sketchpad used by artists, this is where you can start
    typing right away. You can now begin typing in the text above. Keep
    in mind that the exact formatting is not important at this stage;
    however, as we progress in this course, you'll *want* to pay
    attention to how your code is formatted. (With Emacs, it is possible
    to reformat your code to make it *beautiful*. More on that later.)

4.  Once you have entered the text, you will want to *save* it using
    ``ctrl-s ctrl-a`` to a file named ``Hello.cs``. You can also use the
    File menu to save but we mention the control sequence, which works
    on any version of Emacs, including those without a GUI (web servers,
    embedded systems, etc.)

5.  If all has gone well, you will now have a version of *Hello, World*
    in a file named ``Hello.cs`` in a folder named ``hello`` (located in
    ``Documents``).

6.  Now we are going to learn how to compile this program. For this, you
    will need to open a shell. On Linux and OS X, the shell is opened by
    launching Terminal. On Windows, open a Mono Command Prompt,
    as discussed above (or use one you left open).  Again to find it:

    -  OS X: Applications -> Terminal (double click it)
    -  Linux: Applications -> Terminal
    -  Windows: Start Menu, search for Mono Command Line

7.  Now you need to learn how to "move around" using the shell. The
    command shell basically awaits user input and does whatever it is
    told (and does nothing otherwise). You'll begin by using the "cd"
    command to change your working directory to where you saved
    ``Hello.cs``. 
    Note:  Replace Dr. Thiruvathukals's login id gkt by your login id.
    Also note for Mac/Unix examples that his machine is called 
    macaroni.
    
    If you did everything right, you can do this on
    Windows.  ::    
    
        C:\Windows\System32> cd C:\users\LOGIN
        C:\Users\LOGIN> cd Documents\hello
        C:\Users\LOGIN\Documents\hello> 

    Mac/Linux::

        $ cd Documents/hello

8.  If you are on OS X or Linux, you can list the directory using the
    ``ls`` command. If the output you see here does not match, make sure
    you are in the ``hello`` folder::

        $ ls

        macaroni:hello gkt$ ls
        hello.cs

        $ pwd
        /Users/gkt/Documents/hello

9.  If you're on Windows, can list the contents of the directory using
    ``dir``::

        C:\Users\gkt\Documents\hello>dir
		 Volume in drive C has no label.
		 Volume Serial Number is 2C13-C918
		
		 Directory of C:\Users\anh\Documents\hello
		
		01/16/2012  06:07 PM    <DIR>          .
		01/16/2012  06:07 PM    <DIR>          ..
		11/04/2011  08:20 PM               646 Hello.cs
		
		...

10. If you are unable to see ``Hello.cs`` at this stage, you need to go
    back and check all previous steps. It is entirely possible you did
    not create the folder or save properly. If you think you completed
    these steps, this is a good time to ask the instructor or teaching
    assistant for help.

11. Assuming you are able to see ``Hello.cs`` in the ``hello`` folder,
    we are now ready for *the good stuff*~~the technical term we use
    when we are about to learn something that we need to know how to do
    *for life*. We're going to compile the ``Hello.cs`` program into
    ``Hello.exe`` so we can run it. FYI, you should still be in the
    Terminal/DOS window where we just listed the directory (this works
    regardless of what OS you are using). Enter::

        gmcs Hello.cs

12. If everything worked right, you will not see any output. If you spot
    any error messages, it means that you probably made a typo when
    copying/typing the sample code into the text editor. Go back to step
    @EditHello and check that everything is typed properly. (We will not
    be discussing all the possible errors you an encounter at this
    stage, but you might find them helpful to edit your program.) If
    your text editor is not still open, then you need to re-open the
    file, which can be done easily by using File->Open and browsing your
    folder structure to find folder ``hello``, then ``Hello.cs``.

13. Now for the great moment you have been awaiting: You can *run*
    ``Hello.exe``.  Enter::

        mono Hello.exe
        
    You should see the result::
    
        Hello, World!

At this point, we have accomplished the major objective for Lab 0: to
enter, compile, and run a C# program. In the next lab, we will work on
some revisions to ``Hello.cs`` to personalize it a bit.

As this point, you should grab the instructor or teaching assistant so
they can perform a quick inspection of your work and check it off. Per
the syllabus, labs are not graded but do need to be completed to receive
credit. If you are unable to make class on a lab day, please make sure
that you complete the work and demonstrate it by the beginning of the
next lab.

For further reinforcement
~~~~~~~~~~~~~~~~~~~~~~~~~

1. Download and install the Emacs and Mono Software Development Kit on
   your home computer or laptop.

2. Make sure you an do everything that you just completed in the lab.

3. See whether you can get a head start on Lab 1.

What's next in Lab 1?
~~~~~~~~~~~~~~~~~~~~~

We'll continue learning more about C#. The next lab will give you
exposure to the C# interactive mode (in Mono, the ``csharp`` command),
where we will learn to work with arithmetic and basic primitive types.
The ``csharp`` command allows you to use C# as a sort of "toy
calculator" language. It also allows you to test capabilities of the C#
*programming library*. For example, we will learn some other things you
can do with the ``Console`` interfaces, including how to prompt a user
for input.
