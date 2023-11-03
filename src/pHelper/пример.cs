// Файл CRMP
public int ReadNicknameVisibility()
{
    // Замените address на адрес видимости никнеймов
    IntPtr address = (IntPtr)0x12345678; // Замените это на реальный адрес
    byte[] buffer = new byte[4];
    ReadProcessMemory(handle, address, buffer, 4, out IntPtr lpNumberOfBytesRead);
    return BitConverter.ToInt32(buffer, 0);
}

public void WriteNicknameVisibility(int value)
{
    IntPtr address = (IntPtr)0x12345678; // Заменить это на реальный адрес
    byte[] wBytes = BitConverter.GetBytes(value);
    WriteProcessMemory(handle, address, wBytes, 4, out UIntPtr ptrBytesWritten);
}
// Файл pHelper
public int SaveNicknameVisibility()
{
    // Здесь мы сохраняем текущее значение видимости никнеймов
    return ReadNicknameVisibility();
}

public void RestoreNicknameVisibility(int savedValue)
{
    // Восстанавливаем значение видимости никнеймов
    WriteNicknameVisibility(savedValue);
}
private void RestoreNicknameVisibilityButton_Click(object sender, EventArgs e)
{
    if (!m.CH()) return;

    // Восстанавливаем стандартное значение видимости никнеймов, используя сохраненное значение
    int savedVisibility = GetSavedVisibilityValue(); // Получите значение из сохраненных настроек
    m.RestoreNicknameVisibility(savedVisibility);
}


// Вариант №2
// файл CRMP
public int NicknameVisibility { get; private set; }

public void SaveNicknameVisibility()
{
    // Сохраняем текущее значение видимости никнеймов
    NicknameVisibility = ReadNicknameVisibility();
}

public void RestoreNicknameVisibility()
{
    // Восстанавливаем значение видимости никнеймов
    WriteNicknameVisibility(NicknameVisibility);
}
public void ChangeNicknameVisibility(int newValue)
{
    // Здесь вы меняете видимость никнеймов и сохраняете новое значение
    WriteNicknameVisibility(newValue);
    NicknameVisibility = newValue;
}
// Файл pHelper
private void SaveNicknameVisibilityButton_Click(object sender, EventArgs e)
{
    if (!m.CH()) return;

    // Вызываем метод из CRMP для сохранения текущей видимости никнеймов
    m.SaveNicknameVisibility();

    // Здесь можно сохранить значение из CRMP в переменной
}

private void RestoreNicknameVisibilityButton_Click(object sender, EventArgs e)
{
    if (!m.CH()) return;

    // Вызыв метода из CRMP для восстановления стандартной видимости никнеймов
    m.RestoreNicknameVisibility();
}
