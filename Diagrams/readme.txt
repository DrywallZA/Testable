Untestable.

Through this journey I have find out there are two main things that are not "testable".

1) Access modifiers (Private, Protected, Internal)

2) The way code is written. This a little bit more difficult to identify.

   Example: If you have a function that uses a static dependancy like DateTime.Now() and you want to write a test for it an you need to test depending on the time.
            You will have inconsistent tests (flakey), because depending on when you run the test the result can change.

   Example: The same goes for Abstract classes and its members. You can not directly test them but the implementation of it you can.

   Example: Things that are changing. 
            Lets say we have some function that does something with a external dependancy (API, Files, Databases).
            The problem here is that our tests might be very unstable and cant account for something going wrong that is not our codes fault. (Yes this will help us see something is wrong though)

   Example: Code that have more than one responsibility BUT from a technology perspective (Some function that deals with I/O and business logic and some UI component).
            This makes it difficult to isolate behaviour and we should not bend tests to work with bad code.