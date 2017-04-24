using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamCoolCtrl :  MonoBehaviour, connect4CTRL{
    int[,] board;
    int winner;
    connect4AI player1;
    connect4AI player2;
    bool playeronesturn;
    public bool waitForNext = false;
    public bool CheckGameState()
    {
        for( int i = 0; i < 6; i++)
        {
            for( int j = 0; j < 6; j++)
            {
                for (int side = 1; side < 3; side++)
                {
                    if (i + 4 < 6 && board[i, j] == side && board[i + 1, j] == side && board[i + 2, j] == side && board[i + 3, j] == side)
                    {
                        winner = side;
                        return true;
                    }
                    if (j + 4 < 6 && board[i, j] == side && board[i, j + 1] == side && board[i, j + 2] == side && board[i, j + 3] == side)
                    {
                        winner = side;
                        return true;
                    }
                    if (i + 4 < 6 && j + 4 < 6 && board[i, j] == side && board[i + 1, j + 1] == side && board[i + 2, j + 2] == side && board[i + 3, j + 3] == side)
                    {
                        winner = side;
                        return true;
                    }
                    if (i - 4 > 0 && j + 4 < 6 && board[i, j] == side && board[i - 1, j + 1] == side && board[i - 2, j + 2] == side && board[i - 3, j + 3] == side)
                    {
                        winner = side;
                        return true;
                    }
                }



            }
        }
        for (int i = 0; i < 7; i++)
        {
            if (i == 6)
                return true;
            for (int j = 0; j < 6; j++)
            {
                if (board[i,j] == 0)
                {
                    i = 8;
                    j = 8;
                }
            }
            
        }

                return false;
    }

    public void GameStart()
    {
        board = new int[6, 6];
        connect4AI[] ais = gameObject.GetComponents<connect4AI>();
        player1 = ais[0];
        player2 = ais[1];
        playeronesturn = false;
    }

    public int[,] GetBoard()
    {
        return board;
    }

    public void NextTurn()
    {
        if (CheckGameState())
            return;
        int place;
        if ( playeronesturn)
            place = player2.Place(board);
        else
            place = player1.Place(board);

        Debug.Log(place);
        for (int i = 0; i < 6; i++)
        {
            if (board[place, i] == 0)
            {
                board[place, i] = (playeronesturn ? 2 : 1);
                Debug.Log(place + " " + i);
                i = 6;
            }
            


        }
        playeronesturn = !playeronesturn;
        
        if (waitForNext)
        {
            return;
        }
        else
            NextTurn();
    }

}
