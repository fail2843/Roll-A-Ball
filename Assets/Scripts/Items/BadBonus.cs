
using UnityEngine;
internal sealed class BadBonus : InteractiveObjects
{
    protected override void Interaction()
    {
        //����� ��� ���������� ����� �������� � ��������� �����
        Debug.LogWarning("This is a Bad Bonus");
    }
}