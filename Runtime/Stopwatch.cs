using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WaterKat.CustomTime
{
    [Serializable]
    public class Stopwatch
    {
        private float startTime = 0;

        public float CheckElapsedTime(float currentTime)
        {
            return currentTime - startTime;
        }

        public bool CheckForTime(float currentTime, float goalTime)
        {
            return (currentTime - startTime)>=goalTime;
        }

        public bool CheckForTimeAndContinue(float currentTime, float goalTime)
        {
            if ((currentTime - startTime) >= goalTime)
            {
                startTime += goalTime;
                return true;
            }
            return false;
        }

        public void RestartStopwatch(float startTime)
        {
            this.startTime = startTime;
        }

        public Stopwatch(float startTime)
        {
            this.startTime = startTime;
        }
    }
}
