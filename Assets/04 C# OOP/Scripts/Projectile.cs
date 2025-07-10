using System;
using UnityEngine;

public class Projectile
{
    private float speed;

    //Contructor
    public Projectile(float speed)
    {
        this.speed = speed;
    }

    public void Fire()
    {
        if (speed > 0)
        {
            Console.WriteLine("Firing projectile at speed X");
        }
        else
        {
            Console.WriteLine("Cannot fire: speed too low");
            AutoFIre();
        }
    }

    public void AutoFIre()
    {
        Console.WriteLine("Speed was zero. AutoFIre set speed to 100 and launched!");
    } 
}
