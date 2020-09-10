## Anthony Scholeno
## ASP.NET HW06

1. What is unit testing as defined by the book?

Unit testing is a form of testing in which individual components are isolated from the rest of the application so their behavior can be thoroughly validated.

2. What is the convention for creating unit tests in ASP.NET Core applications?

you generally create a separate Visual Studio project to hold the unit tests, each of which is defined as a method in a C# class.

3. Name three unit test project tools used for ASP.NET Core applications.

mstest This template creates a project configured for the MS Test framework, which is produced by Microsoft.
nunit This template creates a project configured for the NUnit framework.
xunit This template creates a project configured for the XUnit framework.

4. What is the convention for naming unit tests in ASP.NET Core applications?

The convention is to name the unit test project <ApplicationName>.Tests

5. What is the convention for naming the test classes in AP.NET Core? What is the convention for naming the methods in the test classes?

Conventionally, the name of the test methods describes what the test does, and the name of the class describes what is being tested.

6. What is the purpose of the Fact attribute in Xunit? (not in book) What is the purpose of the Theory attribute in Xunit?

The Fact attribute and the Asset class are defined in the Xunit namespace, for which there must be a using statement in every test class.

7. Describe the different elements of the AAA testing pattern.

arrange setting up the conditions for the test
act refers to performing the test,
assert refers to verifying that the result was the one that was expected

8. Describe the use of the methods in the Assert class. Describe the purpose, parameters, and return value of the Assert.Equals() method.

Each Assert method allows different types of comparison to be made and throws an exception if the result is not what was expected.

9. What is the key to isolating a component for testing?

The key to isolating components is to use C# interfaces

10. What is a mocking package? What does it do?

makes it easy to create fake—or mock—objects for tests.

11. (not in book) What is the difference between the Setup() and the SetupGet() methods of Moq?

Setup() can be used for mocking a method or a property.
SetupGet() is specifically for mocking the get of a property