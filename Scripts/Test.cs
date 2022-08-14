using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quartzified.Collections;
using  rnd = Quartzified.Mathematics.Random;

public class Test : MonoBehaviour
{
    public string[] array = new string[10];
    public List<string> list = new List<string>();
    public Dictionary<int, string> dict = new Dictionary<int, string>();

    private void Start()
    {
        ExtensionTests();
    }


    public void ExtensionTests(string logTitle = "[Extensions]")
    {
        Log(logTitle, "Setting Up Tests...");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.GetRandom(0, array.Length - 1).ToString();
        }

        for (int i = 0; i < 10; i++)
        {
            int value = rnd.GetRandom(0, array.Length - 1);

            list.Add(value.ToString());
            dict.Add(i, value.ToString());
        }


        Log(logTitle, "Starting Tests...");

        Log(logTitle + "(Array)", array.ToString(true));
        array.Shuffle();
        Log(logTitle + "(Array)", array.ToString(true));

        Log(logTitle + "(List)", list.ToString(true));
        list.Shuffle();
        Log(logTitle + "(List)", list.ToString(true));

        Log(logTitle + "(Dictionary)", dict.ToString());
        dict.Shuffle();
        Log(logTitle + "(Dictionary)", dict.ToString());

        Log(logTitle, "Ending Tests...");
    }

    void Log(string logTitle, object message) => Debug.Log(logTitle + " " + message);

}
