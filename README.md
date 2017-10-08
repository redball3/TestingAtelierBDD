# TestingAtelierBDD
BDD tests and changes for leeds testing atelier

This is an example of how tests which are closely tied to the implementation of software
both have problems with maintenence, and also problems with clarity.

in this solution there are 3 different projects, each one shows how a peice of software can
grow and evolve over time.

As the projects change, the tests need to constantly be restructured for each seperate implementaion
showing the need to refactor the tests to have a clearer and more robust tests.

# running the tests

*option 1*
- open in visual studio and run unit tests
 
*option 2*
- open visual studio command prompt `MStest <path to solution>/<TestProject.dll>`