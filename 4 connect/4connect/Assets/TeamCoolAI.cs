using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamCoolAI : MonoBehaviour, connect4AI {

    int team = 1;
    int enemyTeam = 2;

    public int Place(int[,] board)
    {
        System.Random random = new System.Random();
        int r = random.Next(0, 6);
        if (board[r, board.GetLength(1)-1] == 0)
            return r;
        else return Place(board);
    }

    public void SetTeam(int teamNumber)
    {
        if( teamNumber == 2)
        {
            team = 2;
            enemyTeam = 1;
        }

    }
}
