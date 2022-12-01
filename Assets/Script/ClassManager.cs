using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassManager : MonoBehaviour
{
    public BaseClass[] Class;
    
    private void Start()
    {
        foreach (var Class in Class)
        {
            Class.IntroduceSelf();
            Class.ShowStats(0, 0, 0);
            Class.CharacterStory();
        }
    }

}
