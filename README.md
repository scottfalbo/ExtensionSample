# Basic C# Extension Methods

Basic sample of a C# extension method class.

This project implements:

- A basic model
- Extension class to check some simple conditionals.
- Unit tests to assert on the Extension methods.

## MeowCatExtensions Class

| method | return type | parameters | description |
| - | - | - | - |
| IsSameAge | bool | MeowCat otherMeow | Compares the age of the calling object and argument. |
| IsSameType | bool | MeowCat otherMeow | Compares the type of the calling object and argument. |
| IsSameAgeAndType | bool | MeowCat otherMeow | Compares the age and type of the calling object and argument. |
| GetInfo | void |  | Console writes all of the MeowCat's properties. |
