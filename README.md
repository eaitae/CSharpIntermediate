# CSharpIntermediate
My solutions to the exercises from the course C# Intermediate: Classes, Interfaces and OOP by Mosh Hamedani

Exercise: Design a Stack
A Stack is a data structure for storing a list of elements in a LIFO (last in, first out) fashion.
Design a class called Stack with three methods.
void Push(object obj)
object Pop()
void Clear() 

Exercise: Design a Stopwatch
Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
provide two methods: Start and Stop. We call the start method first, and the stop method next.
Then we ask the stopwatch about the duration between start and stop. Duration should be a
value in TimeSpan. Display the duration on the console. 

Exercise: Design a StackOverflow Post
Design a class called Post. This class models a StackOverflow post. It should have properties
for title, description and the date/time it was created. We should be able to up-vote or down-vote
a post. We should also be able to see the current vote value. In the main method, create a post,
up-vote and down-vote it a few times and then display the the current vote value. 

Exercise: Design a workflow engine
Design a workflow engine that takes a workflow object and runs it. A workflow is a series of steps
or activities. The workflow engine class should have one method called Run() that takes a
workflow, and then iterates over each activity in the workflow and runs it.

Exercise: Design a database connection
To access a database, we need to open a connection to it first and close it once our job is done.
Connecting to a database depends on the type of the target database and the database
management system (DBMS). For example, connecting to a SQL Server database is different
from connecting to an Oracle database. But both these connections have a few things in
common:
• They have a connection string
• They can be opened
• They can be closed
• They may have a timeout attribute (so if the connection could not be opened within the
timeout, an exception will be thrown).
Your job is to represent these commonalities in a base class called DbConnection. This class
should have two properties:
ConnectionString : string
Timeout : TimeSpan

Now that we have the concept of a DbConnection, let’s work out how to represent a
DbCommand.
Design a class called DbCommand for executing an instruction against the database

OBS: Those are just the exercises "basic idea", not the full structions :) just so you can understand the codes 
