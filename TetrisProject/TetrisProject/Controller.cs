﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TetrisProject.Model;
using static TetrisProject.View;

namespace TetrisProject
{
    public class Controller
    {
        private bool isFallingFinished = false;
        private bool isStarted = false;
        private bool isPaused = false;

        /*21 add in 11/28*/
        private int level = 0;
        private int score = 0;

        private Model.Brick curBrick;
        private Tetrominoes[] board;
        private View GameView;

        public Controller()//初始化
        {
        }
        public void start()//開始按鈕
        {
            //初始化一些狀態
        }
        public void pause()//暫停按鈕
        {
            //設定一些狀態
        }
        public void resume()//繼續按鈕
        {
            //設定一些狀態
        }

        public void update()//每秒更新一次狀態
        {
            if (isFallingFinished)//方塊有沒有到底
            {
                isFallingFinished = false;

                if(GameOverCheck())
                {//GameOver

                   // GameView.update();
                }
                else
                    newBrick();
            }
            else
            {
                BrickOneLineDown();
            }
        }
        
        //方塊移動類  先檢查有沒有到邊界 沒有就執行動作 最後檢查有沒有滿行
        public void BrickDropDown()
        {
            int newY = 0;//設定掉下後的座標
            Brick result = curBrick.moveDown(newY);
            if (MoveCheck(result))
            {
                curBrick = result;
            }
            removeFullLines();
            GameView.update();
        }
        public void BrickMoveRight()
        {
            Brick result = curBrick.moveRight();
            if (MoveCheck(result))
            {
                curBrick = result;
            }
            GameView.update();
        }
        public void BrickMoveLeft()
        {
            Brick result = curBrick.moveLeft();
            if (MoveCheck(result))
            {
                curBrick = result;
            }
            GameView.update();
        }
        public void BrickRotate()
        {
            Brick result = curBrick.rotate();
            if (MoveCheck(result))
            {
                curBrick = result;
            }
            GameView.update();
        }
        private void BrickOneLineDown()//慢慢落下
        {
            Brick result = curBrick.moveOneLineDown();
            if (MoveCheck(result))
            {
                curBrick = result;
            }
            removeFullLines();
            GameView.update();
        }

        private void newBrick()//產生新的方塊
        {

            GameView.update();
        }
        private void removeFullLines()//如果有行數滿時就清除
        {
            //這邊放 如果有行數滿時就清除的code

            isFallingFinished = true;//表示方塊已經落下了
            GameView.update();
        }

        private bool MoveCheck(Brick result)//看有沒有碰到邊界
        {
            return true;
        }
        private bool GameOverCheck()//看有沒有GameOver
        {
            return true;
        }

        /*21 add in 11/28*/
        public void changeLevel(int level)
        {
            //curBrick.changeSpeed();

        }
        public int getScore() { return score; }

    }

}

