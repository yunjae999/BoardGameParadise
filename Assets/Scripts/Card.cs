using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Card : MonoBehaviour
{
    public enum FruitType
    {
        Strawberry,
        Banana,
        Plum,
        Kiwi
    }
    public FruitType m_fruitType;       // ���� ����
    public int m_fruitNum;              // ���� ����
    public int m_cardNum;               // ī�� ��ȣ

    public void Initialize(FruitType type, int num, int cardNum)
    {
        m_fruitType = type;
        m_fruitNum = num;
        m_cardNum = cardNum;
    }
    public void OpenCard()
    {
        transform.Rotate(Vector3.right * 180);
    }
}
