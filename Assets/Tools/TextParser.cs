using System.Collections.Generic;
using UnityEngine;

public class TextParser : MonoBehaviour
{
    public static TextParser Instance;

    private void Awake()
    {
        Instance = this;
    }

    public int[,] TextToTwoSortedArrays (string text)
    {
        List<int> leftInts = new List<int>();
        List<int> rightInts = new List<int>();
        bool leftColumn = true;
        string[] strValues = text.Split(' ');
        foreach (string strValue in strValues)
        {
            if (strValue != "")
            {
                if (leftColumn)
                {
                    leftInts.Add(int.Parse(strValue));
                    Debug.Log("Added " + strValue + " to left");
                }
                else
                {
                    rightInts.Add(int.Parse(strValue));
                    Debug.Log("Added " + strValue + " to right");
                }
                leftColumn = !leftColumn;
            }
        }
        leftInts.Sort();
        rightInts.Sort();
        int[,] result = new int[2, leftInts.Count];
        for (int i = 0; i < leftInts.Count; i++)
        {
            result[0, i] = leftInts[i];
            result[1, i] = rightInts[i];
        }
        return result;
    }
}
