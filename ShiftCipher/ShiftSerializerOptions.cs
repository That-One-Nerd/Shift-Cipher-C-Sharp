namespace CorgiCoder.ShiftCipher;

public record class ShiftSerializerOptions
{
    public static readonly ShiftSerializerOptions Default = new();

    public int offsetCount;

    public ShiftSerializerOptions()
    {
        offsetCount = 0;
    }
}
