using System.Collections;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public Dealer m_dealer;
    public PlayerManager m_playerManager;
    public int m_playerCount;
    public HalliGalli m_halligalli;
    public RoundWinner m_roundWinner;
    public FinalWinner m_finalWinner;
    public int PlayerCount                              // �� ���� �÷��̾ ����������
    {
        get{ return m_playerManager.PlayerCount; }
    }

    public int GetCurrentPlayer()                       // ���� ������ ������, index�� ��ȯ
    {
        return m_playerManager.CurrentPlayer;
    }
    public void Shuffle(object[] obj)
    {
        m_dealer.Shuffle(obj);
    }
    public void Calculatecard(int cardCount, int playerCount, int[] playerCardCount)
    {
        m_dealer.Calculatecard(cardCount, playerCount, playerCardCount);
    }    
    public void RemovePlayer(int player)
    {
        m_playerManager.RemovePlayer(player);
    }

    public void NextTurn(int player)
    {
        m_playerManager.NextTurn(player);
    }
    public void RingBell(int playernum)
    {
        m_halligalli.RingBell(playernum);
    }
    public void RoundWinMessage(int winner)
    {
        StartCoroutine("CoRoundWinMessage");
        m_roundWinner.SetText(winner);
    }
    public void FinalWinMessage()
    {
        int winner = m_playerManager.m_alivePlayers[0].m_playerNum;
        StartCoroutine("CoFinalWinMessage");
        m_finalWinner.SetText(winner + 1);
    }
    IEnumerator CoRoundWinMessage()
    {
        m_roundWinner.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        m_roundWinner.gameObject.SetActive(false);
    }
    IEnumerator CoFinalWinMessage()
    {
        m_finalWinner.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        m_finalWinner.gameObject.SetActive(false);
    }
}
