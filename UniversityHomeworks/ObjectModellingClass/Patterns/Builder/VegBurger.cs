﻿namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    /// <summary>
    /// Concrete implementation of a vegetarian burger.
    /// </summary>
    public class VegBurger : Burger
    {
        public override string Name() => "Veg Burger";
        public override float Price() => 25.0f;
    }
}
