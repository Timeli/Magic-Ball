using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PredicateGenerator : MonoBehaviour
{
    [SerializeField] private Accelerometr _accelerometr;
    [SerializeField] private TMP_Text _text;

    private void OnEnable()
    {
        _accelerometr.Shaked += ShowPredicate;
    }

    private void OnDisable()
    {
        _accelerometr.Shaked -= ShowPredicate;
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

    
    private void ShowPredicate()
    {
        _text.text = GeneratePredicate();
    }

    private string GeneratePredicate()
    {
        int index = Random.Range(0, _allPredicates.Length);
        return _allPredicates[index];
    }
}
