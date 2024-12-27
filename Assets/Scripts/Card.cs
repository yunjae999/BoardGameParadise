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
    public FruitType m_fruitType;       // 과일 종류
    public int m_fruitNum;              // 과일 개수
    public int m_cardNum;               // 카드 번호

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
