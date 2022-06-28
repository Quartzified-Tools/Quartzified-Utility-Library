using UnityEngine;
using Quartzified.Collections;

public class StringTest : MonoBehaviour
{
    public string testString1 = "Pythagoras";
    public string testString2 = "exquisite";
    public string testString3 = "An achievement that requires great courage, skill, or strength.";
    public string testString4 = "62648953102";


    private void Start()
    {
        Debug.Log("Capitalized 1: " + testString1.IsCapitalized());
        Debug.Log("Capitalized 2: " + testString2.IsCapitalized());

        Debug.Log("Reverse 3: " + testString3.Reverse());
        Debug.Log("Replace 3: " + testString3.Replace('a', '4'));

        Debug.Log("Is Letters 2: " + testString2.IsLetters());
        Debug.Log("Is Letters 3: " + testString3.IsLetters());
        Debug.Log("Is Letters 4: " + testString4.IsLetters());
    }
}
