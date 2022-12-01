using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankClass : BaseClass
{
    public override void IntroduceSelf()
    {
        base.IntroduceSelf();
    }

    public override void ShowStats(int def, int atk, int speed)
    {
        base.ShowStats(200, 50, 30);
    }

    public override void CharacterStory()
    {
        Debug.Log("CS-10 also called as the Warrior of the Ancient West is one of the COMMAND SERIES intelligent machines \n that is made during ancient times to stop the reign of Ed'Zel over ?. ");
    }
}
