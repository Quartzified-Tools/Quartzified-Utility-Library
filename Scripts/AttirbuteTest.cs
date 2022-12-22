using UnityEngine;
using Quartzified.EditorAttributes;

public class AttirbuteTest : MonoBehaviour
{
    [Title("Title Red", "Red")]
    public string bigBoiTitle;

    [Title("Imagine this doesnt work", 13)]
    public string totally;

    [Layer]
    public string stringLayer;

    [Layer]
    public int intLayer;

    [Tag]
    public string stringTag;

    [Tag]
    public int intTag;

    [Button("TestAttributes")]
    public bool checkAttributes;

    public void TestAttributes()
    {

    }
}
