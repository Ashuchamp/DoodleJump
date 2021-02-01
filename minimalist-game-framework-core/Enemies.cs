using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Game
//{
//    class Enemies
//    {
//
//    }
//}

internal class Enemies
{
    private Vector2 location;
    private Texture enemy1 = Engine.LoadTexture("enemy.png");
    private Texture enemy2 = Engine.LoadTexture("enemy.png");
    private int timesHit = 0;

    public Enemies(Vector2 location)
    {
        this.location = location;
    }

    public Vector2 getLocation()
    {
        return location;
    }

    public void drawEnemy(String kind)
    {
        if (kind == "one")
        {
            Engine.DrawTexture(enemy1, location);
        }
        else if (kind == "two")
        {
            Engine.DrawTexture(enemy2, location);
        }
    }

    public void hit(String kind)
    {
        timesHit++;
        if (kind == "one")
        {
            //kill enemy
        }
        else if (kind == "two")
        {
            //change texturee
        }
    }

}