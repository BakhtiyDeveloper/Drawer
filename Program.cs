using System;

Console.Write("Enter the length of the square: ");
string heightUserInput = Console.ReadLine();
int height = Convert.ToInt32(heightUserInput);

Console.Write("Enter the width of the square: ");
string widthUserInput = Console.ReadLine();
int width = Convert.ToInt32(widthUserInput);

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write(" *");
    }
    Console.WriteLine();
}

Console.Write("Enter the height of the triangle: ");
string heightTriangleUserInput = Console.ReadLine();
int triangleHeight = Convert.ToInt32(heightTriangleUserInput);

for (int i = 0; i < triangleHeight; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.Write("Enter the height of the triangle: ");
string heightTriangleUserInputTwo = Console.ReadLine();
int triangleHeightTwo = Convert.ToInt32(heightTriangleUserInputTwo);

for (int i = 0; i < triangleHeightTwo; i++)
{
    for (int j = triangleHeightTwo; j > i; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.Write("Enter the height of the inverted triangle: ");
string heightTriangleUserInputTree = Console.ReadLine();
int triangleHeightTree = Convert.ToInt32(heightTriangleUserInputTree);

for (int i = 0; i < triangleHeightTree; i++)
{
    for (int j = triangleHeightTree; j > i; j--)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.Write("Enter the height of the inverted triangle: ");
string heightTriangleUserInputFour = Console.ReadLine();
int triangleHeightFour = Convert.ToInt32(heightTriangleUserInputFour);

for (int i = 0; i < triangleHeightFour; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(" ");
    }

    for (int j = triangleHeightFour; j > i; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
