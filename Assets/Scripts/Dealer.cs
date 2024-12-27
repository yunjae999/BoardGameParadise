using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dealer : MonoBehaviour
{
    public void Calculatecard(int cardCount, int playerCount, int[] playerCardCount)                            // �� �÷��̾ ���� ī���� ���� ���
    {
        int divide = cardCount / playerCount;    // 1�δ� ī���� ��
        int mod = cardCount % playerCount;
        for (int i = 0; i < playerCount; i++)             // ī�尡 ������ �������� ���� ���, ù��° �÷��̾���� ���徿 �߰�
        {
            playerCardCount[i] = divide + (mod > i ? 1 : 0);
        }
    }
    public void Shuffle(object[] obj)                           // Fisher-Yates ���� �˰���
    {
        System.Random random = new System.Random();     // ���� ������
        for (int i = obj.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);                 // 0 ~ i �������� ���� �ε���
            object temp = obj[i];                     // ���� �ε����� ���� �ε����� ����
            obj[i] = obj[j];
            obj[j] = temp;
        }
    }
}
