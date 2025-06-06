﻿namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    /// <summary>
    /// Concrete implementation of Pepsi drink.
    /// </summary>
    public class Pepsi : ColdDrink
    {
        public override string Name() => "Pepsi";
        public override float Price() => 35.0f;
    }
}
