# RpsGame

The purpose of this repository is to demonstrate a simple application written in a legacy "get-it-done" style that now must be maintained and enhanced. 

The application is an implementation of the game "rock, paper, scissors" played against a computer opponent. While the application works perfectly against our initial specification (we think, having never seen it), there are some obvious deficiencies. Our product manager is itching to include some new features, but we need to get comfortable with the application first. We will do this in three steps:

## Testing

In order to make sure our application works as expected, we need to test its behavior. Manual test plans won't cut it, because we know that tests that aren't run aren't tests at all. While doing the minimal amount of work possible, we will implement unit testing.

Once we have tests, we want to make sure that we cover our code appropriately. Through the use of automated code coverage tools, we can do that visually and enforce gates in the deployment process such that test coverage can't drop.

## SOLID

Five design principles every developer should know, and that this application ignores, are the SOLID principles:

- Single responsibility
- Open/closed
- Liskov substitution
- Interface segregation
- Dependency inversion

We'll practice all five principles after we have testable code to make the code more maintainable as we reach our final objective.

## Evolution and Feature Development

Everyone knows that customers love features. We'll be given some assignments and show how much more easily we can do it once we have tests and a good design in place.