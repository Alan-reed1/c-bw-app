
public enum Mode
{
    solos = 1,
    doubles = 2,
    threes = 3,
    fours = 4,
    four = 5,
    dreams = 6
}
public static class modeUtil
{
    public static Mode GetBedwarsModeFromString(string modeString)
    {
        if (Enum.TryParse(modeString, true, out Mode mode))
        {
            return mode;
        }
        else
        {
            throw new ArgumentException($"Invalid Bedwars mode string: {modeString}");
        }
    }
}