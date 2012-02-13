.. _lab-monodevelop:

.. index::
   single: labs; MonoDevelop

Lab: Using MonoDevelop
======================


Rationale for this Lab
----------------------

Now that we have developed basic fluency in editing, compiling, and
running programs, we are now going to start using something called the
*integrated development environment* (the IDE). Professional software
developers generally prefer the IDE, because the IDE is to software
development as a word processor is to writing. A word processor won't
make you a better writer but will help you to avoid some of the
pitfalls that plague writers: spelling, grammar, and consistent
formatting. When it comes to programming, you've already learned that
working at the command line can be an exercise in frustration. You
will often make basic syntax errors or forget to do something
"grammatically" like declaring a variable or not using a particular
feature of the language properly.

So the IDE is here to help. You might wonder why we don't teach it
from the beginning. The rationale is simple. You neeed to know the
basics of how a program is put together and run. It is part of
learning to think like a computer scientist and software
developer. Furthermore, we want to be able to assume that you know at
least one of the *basics*: executable programs. When we compile a Mono
program, we get an output file named *Name*.exe, where this *Name* can
be anything, say, ``HelloWorld.exe``.

Goals
-----

In this lab, we're going to set the table for the rest of the
course. We're going to create a C# Solution that you can use to do all
of the remaining homework assignments and labs this semester. If you
like, you can create as many solutions as you like, but C# allows you
to create a single solution and add (at any time) projects to it.

We're going to create a solution that will contain three different
projects:

#. A project that contains our familiar Hello, World example. This
   will be used to make sure that everyone can create something that 
   works, much like we did in the first lab.

#. A project that contains the *input* functions that we have been
   using in various examples (e.g. InputInt and InputString).

#. A project that makes use of the *input* functions. This project 
   can contain whatever code you like, including your homework 
   assignment. This project will use something called a *reference* 
   to make use of the *input* library.


Steps
-----

So let's begin. We'll start by creating a *solution* and add projects
to it one at a time.

.. todo:: 
   George fleshing out the details of this lab still.

#. Create the overall solution. I suggest creating a good name,
   ThiruvathukalComp170.


#. Create a project for Hello, World.

#. Create a project for the Input Utilities.

#. Create one or more projects for each of your labs/homeworks. 



