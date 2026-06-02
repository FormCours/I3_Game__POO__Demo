namespace Demo_POO__Heritage.EnumCustom
{
    [Flags]
    public enum CoatTypeEnum
    {
        SHORT = 1,
        LONG = 2,
        WOOLY = 4,
        SPINY = 8,
        PATTERNED = 16, 
        CURLY = 32,
        HAIRLESS = 64,
        WAVY = 128,
        CORDED = 256,
    }
}