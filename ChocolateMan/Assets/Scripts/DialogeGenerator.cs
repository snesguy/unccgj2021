using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DialogeGenerator
{

    private static string[][] dialogue = {
        new string[]{"I don't like chocolate", "Vegetables are good", "I am at peace", "I study"},
        new string[]{"Chocolate is ok?", "I feel different?", "What is this on my face?", "I feel a change slowing coming in me"},
        new string[]{"I hunger but why?", "I need it", "He is coming", "I don't study", "I want chocolate", "When will he come?"},
        new string[]{"I love it", "I need more on me", "Is it CHOCOLATE time?", "More!", "I don't need water"},
        new string[]{"CHOCOLATE", "COVER ME IN CHOCOLATE", "WHERE IS HE!?"},
        new string[]{"DSHALKFAS", "TE CHOCOLATE WIL COM ON Us aL!", "SPRED TE LUV","CHOCOLATEMAN COMES"},
        new string[]{"WE'RE COMING TOGETHER!"}
    };
    public static string getText(int infectionLevel, float infection)
    {
        if(infectionLevel >= dialogue.Length)
            infectionLevel = dialogue.Length - 1;
        return dialogue[infectionLevel][Random.Range(0, dialogue[infectionLevel].Length)];
    }
}
