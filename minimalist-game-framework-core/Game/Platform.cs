using System;
using System.Collections;
using System.Collections.Generic;


public class Platform
{
    readonly Texture Tplat1 = Engine.LoadTexture("plat.png");
    readonly Texture customPlatT = Engine.LoadTexture("plat1.png");
    public Platform()
	{

	}

    public void drawPlatform(String type, Vector2 v)
    {
        if(type.Equals("normal"))
        {
            
        }
    }
}
