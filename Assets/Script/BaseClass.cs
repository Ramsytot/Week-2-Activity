using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass : MonoBehaviour
{
   public string Name;
   public float Health;
   public string FightingStyle;

   private int _def;
   private int _atk;
   private int _speed;

    
    public virtual void IntroduceSelf()
    {
        Debug.Log($"Hello my name is {Name}, and my role is {FightingStyle}");
    }

    public virtual void ShowStats(int def, int atk, int speed)
    {
        _def = def;
        _atk = atk;
        _speed = speed;
        Debug.Log($"Defence: {_def} Attack: {_atk} Speed: {_speed}");
    }

    public virtual void CharacterStory()
    {
        
    }
}
