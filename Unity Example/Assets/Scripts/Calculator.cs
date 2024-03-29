using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;

namespace ErikOverflow.Classic
{
    public class Calculator
    {
        public GameObject FindClosestObject(List<GameObject> objs, Transform baseObject)
        {
            float shortestDistance = float.PositiveInfinity;
            GameObject closestObject = null;
            Vector3 baseObjPos = baseObject.position;
            //Iterate through all gameObjects, checking the distance to the baseObject
            foreach(GameObject go in objs)
            {
                Vector3 goPos = go.transform.position;
                
                float distance = Vector3.Distance(baseObjPos, goPos);
                if(distance < shortestDistance)
                {
                    shortestDistance = distance;
                    closestObject = go;
                }
            }
            return closestObject;
        }
    }
}
