// ���� CRMP
public int ReadNicknameVisibility()
{
    // �������� address �� ����� ��������� ���������
    IntPtr address = (IntPtr)0x12345678; // �������� ��� �� �������� �����
    byte[] buffer = new byte[4];
    ReadProcessMemory(handle, address, buffer, 4, out IntPtr lpNumberOfBytesRead);
    return BitConverter.ToInt32(buffer, 0);
}

public void WriteNicknameVisibility(int value)
{
    IntPtr address = (IntPtr)0x12345678; // �������� ��� �� �������� �����
    byte[] wBytes = BitConverter.GetBytes(value);
    WriteProcessMemory(handle, address, wBytes, 4, out UIntPtr ptrBytesWritten);
}
// ���� pHelper
public int SaveNicknameVisibility()
{
    // ����� �� ��������� ������� �������� ��������� ���������
    return ReadNicknameVisibility();
}

public void RestoreNicknameVisibility(int savedValue)
{
    // ��������������� �������� ��������� ���������
    WriteNicknameVisibility(savedValue);
}
private void RestoreNicknameVisibilityButton_Click(object sender, EventArgs e)
{
    if (!m.CH()) return;

    // ��������������� ����������� �������� ��������� ���������, ��������� ����������� ��������
    int savedVisibility = GetSavedVisibilityValue(); // �������� �������� �� ����������� ��������
    m.RestoreNicknameVisibility(savedVisibility);
}


// ������� �2
// ���� CRMP
public int NicknameVisibility { get; private set; }

public void SaveNicknameVisibility()
{
    // ��������� ������� �������� ��������� ���������
    NicknameVisibility = ReadNicknameVisibility();
}

public void RestoreNicknameVisibility()
{
    // ��������������� �������� ��������� ���������
    WriteNicknameVisibility(NicknameVisibility);
}
public void ChangeNicknameVisibility(int newValue)
{
    // ����� �� ������� ��������� ��������� � ���������� ����� ��������
    WriteNicknameVisibility(newValue);
    NicknameVisibility = newValue;
}
// ���� pHelper
private void SaveNicknameVisibilityButton_Click(object sender, EventArgs e)
{
    if (!m.CH()) return;

    // �������� ����� �� CRMP ��� ���������� ������� ��������� ���������
    m.SaveNicknameVisibility();

    // ����� ����� ��������� �������� �� CRMP � ����������
}

private void RestoreNicknameVisibilityButton_Click(object sender, EventArgs e)
{
    if (!m.CH()) return;

    // ����� ������ �� CRMP ��� �������������� ����������� ��������� ���������
    m.RestoreNicknameVisibility();
}
