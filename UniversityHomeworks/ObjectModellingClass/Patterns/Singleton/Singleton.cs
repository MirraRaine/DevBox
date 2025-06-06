﻿namespace UniversityHomeworks.ObjectModellingClass.Patterns.Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        // Private constructor prevents instantiation from other classes
        private Singleton() { }

        public static Singleton Instance => _instance;

        public void Execute(string arg)
        {
            // perform operation here
        }
    }
}
