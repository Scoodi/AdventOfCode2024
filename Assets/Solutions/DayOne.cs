using UnityEngine;

public class DayOne : MonoBehaviour
{
    public string values;
    int[,] convertedValues;

    void Start()
    {
        convertedValues = TextParser.Instance.TextToTwoSortedArrays(values);
        Debug.Log("Result is: " + CalculateDistanceTotal());
    }

    int CalculateDistanceTotal()
    {
        int totalDistance = 0;
        for (int i = 0; i < convertedValues.GetLength(1);i++)
        {
            Debug.Log("Adding " + convertedValues[0, i].ToString() + " and " + convertedValues[1, i].ToString());
            totalDistance += Mathf.Abs(convertedValues[0, i] - convertedValues[1, i]);
        }
        return totalDistance;
    }
}
