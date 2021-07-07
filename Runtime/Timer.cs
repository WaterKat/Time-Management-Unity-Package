using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WaterKat.TimeManagement
{
    [Serializable]
    public class Timer
    {
        private float currentTick = 0;
        private float goalTick = 1;

        public float currentTime { get { return currentTick; } }
        public float timeLeft { get { return goalTick - currentTick; } }
        public float goalTime { get { return goalTick; } }

        public bool Tick(float deltaTime)
        {
            currentTick += deltaTime;
            return currentTick >= goalTick;
        }

        public void RestartTimer()
        {
            currentTick = 0;
        }

        public Timer(float desiredTime)
        {
            goalTick = desiredTime;
        }
    }
}
