using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quartzified.EditorAttributes;
using HeaderAttribute = Quartzified.EditorAttributes.HeaderAttribute;

public class AttirbuteTest : MonoBehaviour
{
    [Title("")]
    public string bigBoiTitle;

    [Header("Imagine this doesnt work")]
    public string totally;

    [Header("But in red this would be way cooler", "fsdfs")]
    public string yeaRight;

    //[Button]
    //Nothing here to reference

    void AutoReferenceButtonTest()
    {
        Debug.Log("Auto Reference has worked");
    }

    //[Button("WithReferenceButtonTest")]
    public bool test2; // Has bool to stick too

    public void WithReferenceButtonTest()
    {
        Debug.Log("With Reference has Worked");
    }


}
