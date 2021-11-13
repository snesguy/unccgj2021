using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DialogeGenerator
{

    private static string[][] dialogue = {
        new string[]{"I don't like chocolate", "Vegetables are good", "I am at peace", "I study"},
        new string[]{"Chocolate is ok?", "I feel different?", "What is this on my face?"},
        new string[]{"I hunger but why?", "I need it", "He is coming", "I don't study", "I want chocolate", "When will he come?"}
    };
    public static string getText(int infectionLevel, float infection)
    {
        if(infectionLevel >= dialogue.Length)
            return null;
        return dialogue[infectionLevel][Random.Range(0, dialogue[infectionLevel].Length)];
    }
}
