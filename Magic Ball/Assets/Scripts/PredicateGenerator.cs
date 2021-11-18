using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredicateGenerator : MonoBehaviour
{
    private string _predicate;

    private string[] _allPredicates = new string[]
    {
        "���������",
        "����������",
        "������� ��������",
        "���������� ��",
        "������ ���� ������ � ����",

        "��� ������� - \"��\"",
        "��������� �����",
        "������� �����������",
        "������� ������� - \"��\"",
        "��",

        "���� �� ����, �������� �����",
        "������ �����",
        "����� �� ������������",
        "������ ������ �����������",
        "��������������� � ������ �����",

        "���� �� �����",
        "��� ����� - \"���\"",
        "�� ���� ������ - \"���\"",
        "����������� �� ����� �������",
        "������ �����������"
    };

    private void Start()
    {
        print(GeneratePredicate());
    }

    private string GeneratePredicate()
    {
        int index = Random.Range(0, _allPredicates.Length);
        return _allPredicates[index];
    }
}
