using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Character
{
    Texture charTexture = Engine.LoadTexture("charR.png");
    //readonly Texture charLeft = Engine.LoadTexture("charL.png");
    //readonly Texture shoot = Engine.LoadTexture("shoot.png");
    private Vector2 charLocation;
    private Boolean powerupActivated;
    //private ArrayList powerups = new ArrayList();

    public Vector2 getLocation()
    {
        return charLocation;
    }

    public Character()
    {
        charLocation = new Vector2(460, 150);
        powerupActivated = false;
    }

    public void respondToKey(Key keyName)
    {
        if (keyName == 'A') // && charLocation.X > 0)
        {
            charTexture = Engine.LoadTexture("charL.png");

            if (charLocation.X < 0)
            {
                charLocation.X = 300;
            }
            charLocation.X = charLocation.X - 5;
        }
        if (keyName == "D") //&& charLocation.X < 290)
        {
            charTexture = Engine.LoadTexture("charR.png");

            if (charLocation.X > 300)
            {
                charLocation.X = 0;
            }
            charLocation.X = charLocation.X + 5;
            Console.WriteLine("D pressed");
        }
        /*if (keyName == "S")
        {
            charLocation.Y = charLocation.Y + 5;
        }
        if (keyName == "W")
        {
            charLocation.Y = charLocation.Y - 10;
        }*/
        if (keyName == "Space")
        {
            charTexture = Engine.LoadTexture("shoot.png");
            Vector2 temp = new Vector2();
            temp = charLocation;
            temp.Y = temp.Y - 2;
            temp.X = temp.X + 15;
            //bullets.Add(temp);
        }
    }

    public void addPowerups(Powerup powerup)
    {
        //get location from char and location of powerups
        if (charLocation.X == powerup.X && charLocation.Y == powerup.Y)
        {
            //if match then add powerup to arraylist
            //powerups.Add(powerup);
            //hold calling this method until powerup = false?
            if (!powerupActivated)
            {
                powerupActivated = true;
                activatePowerup(powerup.getName());
            }
            else
            {
                //callback function?
                while (powerupActivated)
                {
                    Console.WriteLine("Powerup active, so can't activate new powerup.");
                }
                activatePowerup(powerup.getName());
                //keep trying to activate powerup code
            }
        }
    }

    public void activatePowerup(String powerUpName)
    {
        //update textures and physics
        charTexture = Engine.LoadTexture("char" + powerUpName + ".png");
        int changeY = 0;
        switch (powerUpName)
        {
            case "trampoline":
                changeY = 1000;
                break;
            case "helicopterCap":
                changeY = 12;
                break;
            case "jetpack":
                changeY = 20;
                break;
            default:
                break;
        }
        int counter = 50;
        while (counter > 0)
        {
            charLocation.Y += changeY;
            counter--;
        }
        //powerups.RemoveAt(0);
        powerupActivated = false;
    }

    public void jumping()
    {
        if (jump || hittingPlat(charLocation, platforms))
        {
            jump = true;
            if (count < 25 && jump == true)
            {
                count++;
                double x;
                if (hitting(charLocation, trampolines))
                {
                    x = charLocation.Y - 20;
                    height += 20;
                }
                else
                {
                    x = charLocation.Y - 5;
                    height += 5;
                }
                charLocation.Y = (float)x;
                System.Threading.Thread.Sleep(10);
            }
            else
            {
                jump = false;
                count = 0;
                //
            }
        }
        if (charLocation.Y < 100)
        {
            //if(downCount < 25)
            //{
            movePlatsDown();
            if (jump)
            {
                charLocation.Y += 5;
            }
            else
            {
                charLocation.Y += 15;
            }
            downCount++;
            movingDown = true;
        }
        else
        {
            movingDown = false;
            downCount = 0;
        }
    }
}
