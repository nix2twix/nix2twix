pair<uint64_t, uint64_t> EncryptionRound(uint64_t& subKey, uint64_t& L, uint64_t& R)
{
    // ���������� ���������� �������� ������� ����� �����
    uint64_t Rtemp = R;

    R = R + subKey;

    // ���������� �� S-�������� �� 4 ����

    vector<char> subBlocks(FULL_BLOCK_BYTE_SIZE, 0);

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        subBlocks[i] = (R >> (4 * (15 - i))) & 0x0F;

        // ������ �� �������
        subBlocks[i] = ReplacementTable[i][subBlocks[i]];

    }

    // ������ ���������� ������ � ������ ����� �����
    R = 0;

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        R = R | (static_cast<uint64_t>(subBlocks[i]) << (4 * (15 - i)));
    }

    // ����������� ����� �� 11 ��� �����

    R = (R << 11) | (R >> 53);

    // �������� �� ������� ������ �����

    R ^= L;
    L = Rtemp;

    return make_pair(L, R);
}


void DecryptionRound(uint64_t& subKey, uint64_t& L, uint64_t& R)
{
    uint64_t temp = R;
    R = L;

    L = L + subKey;

    // ���������� �� S-�������� �� 4 ����

    vector<char> subBlocks(FULL_BLOCK_BYTE_SIZE, 0);

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        subBlocks[i] = (L >> (4 * (15 - i))) & 0x0F;

        // ������ �� �������
        subBlocks[i] = ReplacementTable[i][subBlocks[i]];
    }

    // ������ ���������� ������ � ������ ����� �����

    L = 0;

    for (int i = 0; i < FULL_BLOCK_BYTE_SIZE; i++)
    {
        L = L | (static_cast<uint64_t>(subBlocks[i]) << (4 * (15 - i)));
    }

    // ����������� ����� �� 11 ��� �����

    L = (L << 11) | (L >> 53);

    L = L ^ temp;

}