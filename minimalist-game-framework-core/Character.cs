using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Game
//{
//    class Character
//    {
//    }
//}

internal class Character
{
    Texture charTexture = Engine.LoadTexture("charR.png");
    //readonly Texture charLeft = Engine.LoadTexture("charL.png");
    //readonly Texture shoot = Engine.LoadTexture("shoot.png");
    private Vector2 charLocation;
    private ArrayList powerups = new ArrayList();

    public Vector2 getLocation()
    {
        return charLocation;
    }



    public void respondToKey()
    {
        if (Engine.GetKeyHeld(Key.A)) // && charLocation.X > 0)
        {
            charTexture = Engine.LoadTexture("charL.png");

            if (charLocation.X < 0)
            {
                charLocation.X = 300;
            }
            charLocation.X = charLocation.X - 5;
        }
        if (Engine.GetKeyHeld(Key.D)) //&& charLocation.X < 290)
        {
            charTexture = Engine.LoadTexture("charR.png");

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
            charTexture = Engine.LoadTexture("shoot.png");
            Vector2 temp = new Vector2();
            temp = charLocation;
            temp.Y = temp.Y - 2;
            temp.X = temp.X + 15;
            //bullets.Add(temp);
        }
    }

    public void addPowerups(String powerup)
    {
        //get location from char and location of powerups
        //if match then add powerup to arraylist
    }

    public void activatePowerups()
    {
        //go through arraylist of powerups and activate all
        //update textures
        //remove power up from array when time is over
    }
}
