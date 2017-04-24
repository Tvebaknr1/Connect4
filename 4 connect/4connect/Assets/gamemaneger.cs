using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemaneger : MonoBehaviour {
    public GameObject controllor;
    int[,] board;
    int[,] oldboard;
    public GameObject[] row1;
    public GameObject[] row2;
    public GameObject[] row3;
    public GameObject[] row4;
    public GameObject[] row5;
    public GameObject[] row6;
    private void Start()
    {
        controllor.GetComponent<TeamCoolCtrl>().GameStart();
        board = controllor.GetComponent<TeamCoolCtrl>().GetBoard();
        oldboard = new int[board.GetLength(0), board.GetLength(1)];
    }
    private void Update()
    {
        board = controllor.GetComponent<TeamCoolCtrl>().GetBoard();
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] != oldboard[i, j])
                {
                    gotinput(i, board[i, j]);
                    oldboard[i, j] = board[i,j];
                }
            }
        }
    }
    void gotinput(int row,int team)
    {
        switch (row)
        {
            case 0:
                {
                    foreach (var item in row1)
                    {
                        if (!item.GetComponent<team>().isteam)
                        {
                            item.GetComponent<team>().setteam(team);
                            return;
                        }
                    }
                    return;
                }
            case 1:
                {
                    foreach (var item in row2)
                    {
                        if (!item.GetComponent<team>().isteam)
                        {
                            item.GetComponent<team>().setteam(team);
                            return;
                        }
                    }
                    return;
                }
            case 2:
                {
                    foreach (var item in row3)
                    {
                        if (!item.GetComponent<team>().isteam)
                        {
                            item.GetComponent<team>().setteam(team);
                            return;
                        }
                    }
                    return;
                }
            case 3:
                {
                    foreach (var item in row4)
                    {
                        if (!item.GetComponent<team>().isteam)
                        {
                            item.GetComponent<team>().setteam(team);
                            return;
                        }
                    }
                    return;
                }
            case 4:
                {
                    foreach (var item in row5)
                    {
                        if (!item.GetComponent<team>().isteam)
                        {
                            item.GetComponent<team>().setteam(team);
                            return;
                        }
                    }
                    return;
                }
            case 5:
                {
                    foreach (var item in row6)
                    {
                        if (!item.GetComponent<team>().isteam)
                        {
                            item.GetComponent<team>().setteam(team);
                            return;
                        }
                    }
                    return;
                }

        }

    }
    public void nextturn()
    {
        controllor.GetComponent<TeamCoolCtrl>().NextTurn();
        
    }
}
