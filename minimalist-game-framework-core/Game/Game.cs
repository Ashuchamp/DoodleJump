﻿using System;
using System.Collections;
using System.Collections.Generic;

class Game
{
    public static readonly string Title = "Minimalist Game Framework";
    public static readonly Vector2 Resolution = new Vector2(320, 480);

    Texture charRight = Engine.LoadTexture("charR.png");
    readonly Texture charLeft = Engine.LoadTexture("charL.png");
    readonly Texture bulletPic = Engine.LoadTexture("bullet.png");
    readonly Texture enemyPic = Engine.LoadTexture("enemy.png");
    readonly Texture trampolineTex = Engine.LoadTexture("trampoline.png");
    readonly Font font = Engine.LoadFont("FiraCode-Medium.ttf", pointSize: 20);
    //readonly Texture Tplat2 = Engine.LoadTexture("plat.png");
    //readonly Texture Tplat3 = Engine.LoadTexture("plat.png");

    readonly Texture background = Engine.LoadTexture("background.jpg");

    Vector2 charLocation = new Vector2(145, 440);
    //Vector2 platLocation = new Vector2(100, 300);
    List<Platform> platforms = new List<Platform>();
    ArrayList trampolines = new ArrayList();
    ArrayList bullets = new ArrayList();
    ArrayList enemies = new ArrayList();
    ArrayList brokenPlatforms = new ArrayList();
    Vector2 bck = new Vector2(0, 0);

    Vector2 plat1 = new Vector2(100, 300);

    Vector2 plat2 = new Vector2(200, 90);

    Vector2 plat3 = new Vector2(250, 30);

    Vector2 scoreVec = new Vector2(10, 10);

    int time = 0;
    //    public void plats()
    //    { 
    //        Random random = new System.Random();
    //        for (int i = 0; i < 5; i++)
    //        {
    //            Vector2 temp = new Vector2(random.Next(0, 280), random.Next(50, 400));
    //            platforms.Add(temp);
    //            Engine.DrawTexture(plat1, temp);
    //
    //        }
    //    }

    public Game()
    {

    }

    int score = 0;
    int count = 0;
    Boolean jump = false;

    Boolean compiled = false;
    Boolean movingDown = false;
    int downCount = 0;
    int lastPlatY = 470;

    ScoreBoard sb = new ScoreBoard();
    Character main = new Character();

    public void Update()
    {
        //platforms.Add(plat1);
        //platforms.Add(plat2);
        //platforms.Add(plat3);

        if (isGameOver(charLocation))
        {
            sb.modifyScoreBoard(score);
        }

        Random random = new System.Random();

        if (!jump && !movingDown)
        {
            charLocation.Y += 5;
        }
        //charLocation.Y += 5;

        Engine.DrawTexture(background, bck);
        Engine.DrawTexture(charRight, charLocation);
        //Engine.DrawTexture(Tplat1, plat1);
        //Engine.DrawTexture(Tplat1, plat2);
        //Engine.DrawTexture(Tplat1, plat3);

        if (!compiled)
        {
            lastPlatY = 470;
            Vector2 platVec = new Vector2(140, 465);
            Platform p = new Platform(platVec);
            platforms.Add(p);
            for (int i = 0; i < 10; i++)
            {
                //int enemyProb = random.Next(0, 100);
                lastPlatY = random.Next(lastPlatY - 125, lastPlatY - 50);
                Vector2 temp = new Vector2(random.Next(0, 280), lastPlatY);

                platforms.Add(new Platform(temp));
                //Engine.DrawTexture(customPlatT, temp);
            }
            compiled = true;
        }

        foreach (Platform plat in platforms)
        {
            plat.drawPlatform("normal");
        }
        foreach (Vector2 enemy in enemies)
        {
            Engine.DrawTexture(enemyPic, enemy);
        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        foreach (Powerup tramp in trampolines)
=======
        foreach(Vector2 tramp in trampolines)
>>>>>>> parent of 0051085... Merge branch 'main' into BY-ScoreBoardBranch1
=======
        foreach(Vector2 tramp in trampolines)
>>>>>>> parent of 0051085... Merge branch 'main' into BY-ScoreBoardBranch1
=======
        foreach(Vector2 tramp in trampolines)
>>>>>>> parent of 0051085... Merge branch 'main' into BY-ScoreBoardBranch1
        {
            Engine.DrawTexture(trampolineTex, tramp.getLocation());
        }
        Engine.DrawString(score.ToString(), scoreVec, Color.Purple, font);

        time++;

        makePlatforms();
        main.respondToKey(Engine.GetKeyHeld());
        //charActions();
        jumping();
        //jumping();
        bulletStuff();
        //}
<<<<<<< HEAD
        foreach (Powerup tramp in trampolines)
        {
            if (Math.Abs(charLocation.X - tramp.getLocation().X) <= 5 && Math.Abs(charLocation.Y - tramp.getLocation().Y) <= 5)
            {
                main.activatePowerup(tramp.getName());
            }
        }

<<<<<<< HEAD
<<<<<<< HEAD
=======

        
>>>>>>> parent of 0051085... Merge branch 'main' into BY-ScoreBoardBranch1
=======
        
>>>>>>> parent of 0051085... Merge branch 'main' into BY-ScoreBoardBranch1
=======
        
>>>>>>> parent of 0051085... Merge branch 'main' into BY-ScoreBoardBranch1
        //breakPlatform();

    }

    public void bulletStuff()
    {
        foreach (Vector2 bullet in bullets)
        {
            Engine.DrawTexture(bulletPic, bullet);
        }
        moveBulletUp();
        if (bullets.Count > 0 && enemies.Count > 0)
        {
            checkEnemyDead();
        }
    }

    public void makeBrokenPlatform()
    {
        Random random = new System.Random();
        for (int i = 0; i < platforms.Count; i++)
        {
            if (random.Next(0, 100) < 80)
            {
                brokenPlatforms.Add(platforms[i]);
                Platform temp = (Platform)platforms[1];

            }
        }
    }

    /*public void jumping()
    {
        if (jump || hittingplat(charlocation, platforms))
        {
            jump = true;
            if (count < 25 && jump == true)
            {
                count++;
                double x;
                if (hitting(charlocation, trampolines))
                {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                    x = charlocation.y - 20;
                    height += 20;
                }
                else
                {
                    x = charlocation.y - 5;
                    height += 5;
=======
                    x = charLocation.Y - 20;
=======
                    x = charLocation.Y - 20;
=======
                    x = charLocation.Y - 20;
                }
                else
                {
                    x = charLocation.Y - 5;
>>>>>>> parent of 0051085... Merge branch 'main' into BY-ScoreBoardBranch1
                }
                else
                {
                    x = charLocation.Y - 5;
>>>>>>> parent of 0051085... Merge branch 'main' into BY-ScoreBoardBranch1
                }
                else
                {
                    x = charLocation.Y - 5;
>>>>>>> parent of 0051085... Merge branch 'main' into BY-ScoreBoardBranch1
                }
                charlocation.y = (float)x;
                system.threading.thread.sleep(10);
            }
            else
            {
                jump = false;
                count = 0;
                
            }
        }
        if (charlocation.y < 100)
        {
            if(downcount < 25)
            {
            moveplatsdown();
            if (jump)
            {
                charlocation.y += 5;
            }
            else
            {
                charlocation.y += 15;
            }
            downcount++;
            movingdown = true;
        }
        else
        {
            movingdown = false;
            downcount = 0;
        }
    }

    public void charActions()
    {

        if (Engine.GetKeyHeld(Key.A)) // && charLocation.X > 0)
        {
            charRight = Engine.LoadTexture("charL.png");

            if (charLocation.X < 0)
            {
                charLocation.X = 300;
            }
            charLocation.X = charLocation.X - 5;
        }
        if (Engine.GetKeyHeld(Key.D)) //&& charLocation.X < 290)
        {
            charRight = Engine.LoadTexture("charR.png");

            if (charLocation.X > 300)
            {
                charLocation.X = 0;
            }
            charLocation.X = charLocation.X + 5;
            Console.WriteLine("D pressed");
        }
        if (Engine.GetKeyHeld(Key.S))
        {
            charLocation.Y = charLocation.Y + 5;
        }
        if (Engine.GetKeyHeld(Key.W))
        {
            charLocation.Y = charLocation.Y - 10;
        }
        if (Engine.GetKeyDown(Key.Space))
        {
            charRight = Engine.LoadTexture("shoot.png");
            Vector2 temp = new Vector2();
            temp = charLocation;
            temp.Y = temp.Y - 2;
            temp.X = temp.X + 15;
            bullets.Add(temp);
        }
    }*/

    public void breakPlatform()
    {
        Random random = new System.Random();
        for (int i = 0; i < brokenPlatforms.Count; i++)
        {
            Platform platform = platforms[i];
            if ((Math.Abs(charLocation.X - platform.getVector().X) <= 40 && Math.Abs(charLocation.Y - platform.getVector().Y) <= 29) 
                && random.Next(0, 100) > 80)
            {
                brokenPlatforms.RemoveAt(i);
                return;
            }
        }
    }

    public void moveBulletUp()
    {
        Vector2 temp = new Vector2();
        for (int i = 0; i < bullets.Count; i++)
        {
            temp = (Vector2)bullets[i];
            temp.Y = temp.Y - 15;
            bullets[i] = temp;
        }
        if (bullets.Count > 0)
        {
            temp = (Vector2)bullets[0];
            if (temp.Y < 0)
            {
                bullets.RemoveAt(0);
            }
        }
    }

    public void checkEnemyDead()
    {
        for (int i = 0; i < bullets.Count; i++)
        {
            for (int j = 0; j < enemies.Count; j++)
            {
                Vector2 currentBullet = new Vector2();
                Vector2 currentEnemy = new Vector2();
                if (bullets.Count > 0)
                {
                    currentBullet = (Vector2)bullets[i];
                }
                if (enemies.Count > 0)
                {
                    currentEnemy = (Vector2)enemies[j];
                }
                //if (enemies.Count > 0 && bullets.Count > 0)
                // {
                if ((enemies.Count > 0 && bullets.Count > 0) && (currentBullet.Y - currentEnemy.Y < 40 && currentBullet.X - currentEnemy.X < 40 && currentEnemy.X - currentBullet.X > -9))
                {
                    bullets.RemoveAt(i);
                    i--;
                    enemies.RemoveAt(j);
                    j--;
                }
                // }
            }
        }
    }

    public void movePlatsDown()
    {
        for (int i = 0; i < platforms.Count; i++)
        {
            Platform plat = platforms[i];
            Vector2 temp = plat.getVector();
            temp.Y = temp.Y + 10;           
            platforms[i].modifyVector(temp);         
        }

        for (int i = 0; i < enemies.Count; i++)
        {
            Vector2 temp = (Vector2)enemies[i];
            temp.Y = temp.Y + 10;
            enemies[i] = temp;
        }

        for (int i = 0; i < trampolines.Count; i++)
        {
            Vector2 temp = trampolines[i].getLocation();
            temp.Y = temp.Y + 10;
            trampolines[i].setLocation() = temp;
        }
    }

    public void makePlatforms()
    {
        Random random = new System.Random();

        Vector2 temp1 = platforms[0].getVector();
        if (temp1.Y > 490)
        {
            temp1 = platforms[platforms.Count - 1].getVector();
            int yLoc = (int)temp1.Y;
            int newY = random.Next(yLoc - 125, yLoc - 50);
            int newX = random.Next(0, 280);
            platforms.Add(new Platform(new Vector2(newX, newY)));
            platforms.RemoveAt(0);

            int enemyProb = random.Next(0, 100);
            int trampolineProb = random.Next(0, 100);

            if (enemyProb < 20)
            {
                Vector2 enemyTemp = new Vector2(newX, newY - 40);
                enemies.Add(enemyTemp);
            }

            if(trampolineProb < 10)
            {
                Powerup trampoline = new Powerup("trampoline", new Vector2(newX, newY - 40));
                trampolines.Add(trampoline);
            }
        }
    }

    public Boolean hittingPlat(Vector2 charLocation, List<Platform> platforms)
    {
        foreach (Platform platform in platforms)
        {
            if (platform.hittingPlatform(charLocation))
            {
                return true;
            }
        }

        return false;
    }

    public Boolean hitting(Vector2 charLocation, ArrayList platforms)
    {
        foreach (Vector2 platform in platforms)
        {
            if (Math.Abs(charLocation.X - platform.X) <= 5 && Math.Abs(charLocation.Y - platform.Y) <= 5)
            {
                return true;
            }
        }

        return false;
    }

    public Boolean isGameOver(Vector2 playerLocation)
    {
        return playerLocation.Y > Resolution.Y;
    }

}