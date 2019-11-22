using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;

namespace ErikOverflow.Classic
{
    public class Calculator
    {
        public void CalculateDistance(List<GameObject> planets)
        {
            float overallMin = float.infinity;
            float overallMax = 0f;
            //Go through each planet and find the shortest and longest distance between all other planets
            foreach(GameObject planet in planets)
            {
                float planetMin = float.infinity;
                float planetMax = 0f;
                Vector3 planetPos = planet.transform.position;
                //Find the shortest and longest distance between the current planet and all other planets
                foreach(GameObject otherPlanet in planets)
                {
                    if(otherPlanet == planet)
                        continue;
                    Vector3 otherPos = otherPlanet.transform.position;
                    float distance = Vector3.distance(otherPos, planetPos);
                    if(distance < planetMin)
                        planetMin = distance;
                    if(distance > planetMax)
                        planetMax = distance;
                }
                if(planetMin < overallMin)
                    overallMin = planetMin;
                if(planetMax > overallMax)
                    overallMax = planetMax;
            }
        }
    }
}
