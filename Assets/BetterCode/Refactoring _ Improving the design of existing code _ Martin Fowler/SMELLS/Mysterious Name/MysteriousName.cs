using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MysteriousName_Before
{
    public class Thing
    {
        public void MethodX(float p)
        {
            float result = p * 10f;
            Debug.Log(result);
        }
    }
}

namespace MysteriousName_After
{
    public class Score
    {
        public void CalculateScore(float points)
        {
            float score = points * 10f;
            Debug.Log(score);
        }
    }
}