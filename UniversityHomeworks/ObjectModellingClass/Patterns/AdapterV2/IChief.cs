/// <summary>
/// Target interface expected by the client (e.g., a kitchen system).
/// Represents the role of a Chief who can make breakfast, lunch, and dinner.
/// </summary>
public interface IChief
{
    object MakeBreakfast();
    object MakeLunch();
    object MakeDinner();
}