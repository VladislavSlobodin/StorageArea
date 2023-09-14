namespace StorageArea;

public static class ExtensionMethods
{
    public static int Hash(this string str)
    {
        long hash = int.MaxValue;
        foreach (var c in str)
        {
            hash = (37 * hash + c) % int.MaxValue;
        }

        return Convert.ToInt32(hash);
    }
}
