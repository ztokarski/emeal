using System;

namespace emeal.Exceptions
{
    public class InvalidRecipeException : ArgumentException
    {
    }

    public class InvalidRecipeIdException : InvalidIdException
    {
    }
}