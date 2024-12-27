using UnityEngine;

public class Player : MonoBehaviour
{
    public int m_playerNum;
    public HalliGalli m_halligalli;
    public bool m_isMyTurn;             // �� ������ üũ, true�϶��� opencard����
    public bool m_isGetInput;           // space bar input �ϳ��� �ޱ� ����, ��Ƽ�÷��̰� �Ǹ� ���� ��

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && m_isMyTurn && m_isGetInput)    // OpenCard üũ��
        {
            m_halligalli.OpenCard(m_playerNum);
        }
        if(Input.GetKeyDown(KeyCode.Space) && m_isGetInput)
        {
            GameManager.Instance.RingBell(m_playerNum);
        }
    }
}