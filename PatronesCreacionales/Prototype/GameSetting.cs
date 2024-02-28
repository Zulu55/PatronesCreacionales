using Prototype;

public class GameSetting : IPrototype<GameSetting>
{
    public string Difficulty { get; set; }
    public string Controls { get; set; }
    public bool SoundEnabled { get; set; }

    public GameSetting(string difficulty, string controls, bool soundEnabled)
    {
        Difficulty = difficulty;
        Controls = controls;
        SoundEnabled = soundEnabled;
    }

    // Implementation of the Clone method
    public GameSetting Clone()
    {
        // MemberwiseClone performs a shallow copy
        return (GameSetting)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Difficulty: {Difficulty}, Controls: {Controls}, Sound Enabled: {SoundEnabled}";
    }
}