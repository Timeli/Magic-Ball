using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PredicateGenerator : MonoBehaviour
{
    [SerializeField] private Accelerometr _accelerometr;

    public delegate void TextEventHandler(string predicate);
    public event TextEventHandler PredicateEnded;

    private void OnEnable()
    {
        _accelerometr.Shaked += GeneratePredicate;
    }

    private void OnDisable()
    {
        _accelerometr.Shaked -= GeneratePredicate;
    }

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

    
    private void GeneratePredicate()
    {
        int index = Random.Range(0, _allPredicates.Length);
        string predicate = _allPredicates[index];

        PredicateEnded?.Invoke(predicate);
    }
}
