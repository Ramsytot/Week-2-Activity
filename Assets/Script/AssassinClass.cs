using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssassinClass : BaseClass
{
     public override void IntroduceSelf()
    {
        base.IntroduceSelf();
    }

    public override void ShowStats(int def, int atk, int speed)
    {
        base.ShowStats(75, 100, 150);
    }

    public override void CharacterStory()
    {
        Debug.Log("Satoshi a ninja from the Scarlet sect who aims to unite the 4 sects of Ayakashi region");
    }
}
