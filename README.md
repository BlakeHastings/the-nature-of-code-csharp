# the-nature-of-code-csharp
This is a repository for storing examples from Daniel Shiffman's book The Nature of Code.

# Setting up the mono game project for each example

1.) scaffold a new console project:
`dotnet new console`
2.) add the new project to the solution file:
`dotnet sln add <path-to-project>`
3.) add mono game packages:
`dotnet add package Monogame.Framework.DesktopGL`
`dotnet add package MonoGame.Content.Builder.Task`
4.) create a folder for the example
`mkdir <example-name>`
5.) create monogame project in folder
`dotnet new mgwindowsdx`