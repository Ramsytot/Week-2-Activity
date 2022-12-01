using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageClass : BaseClass
{
    public override void IntroduceSelf()
    {
        base.IntroduceSelf();
    }

    public override void ShowStats(int def, int atk, int speed)
    {
        base.ShowStats(200, 150, 75);
    }

    public override void CharacterStory()
    {
        Debug.Log("Avery the princess of Lumina kingdom and daughter of King Alter also known as Double King.");
    }
}
