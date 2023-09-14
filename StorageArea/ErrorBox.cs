namespace StorageArea;

public static class ErrorBox
{
    public static void Show(string message) => MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
