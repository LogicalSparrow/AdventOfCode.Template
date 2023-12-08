# Advent of Code C# Template

A handy C# solution template for preparing to solve the [Advent Of Code](https://adventofcode.com/) problems and benchmark the solutions!

## Installation

Once the repository is on your computer, in a terminal `cd` to the root folder and run the following:

    dotnet new install

This will install the template for use by the `dotnet new` tool. You should see something like this:

    The following template packages will be installed:
       F:\Programming\CSharp\AdventOfCode\AdventOfCode.Template

    Success: F:\Programming\CSharp\AdventOfCode\AdventOfCode.Template installed the following templates:
    Template Name            Short Name  Language  Tags
    -----------------------  ----------  --------  -------
    Advent Of Code Template  aoc         [C#]      Console

## Usage

To generate a solution from this template, `cd` to the folder above where you want the solution folder to be created and execute this:

    dotnet new aoc -n Your.Namespace.Here
