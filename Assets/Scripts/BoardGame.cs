using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface BoardGame
{
    public void GameSetting();
    public void PlayTurn();
    public void Win();
    public void Lose();
    public void FinishGame();
    public bool IsCorrect();
}
