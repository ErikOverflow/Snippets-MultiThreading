using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;

namespace ErikOverflow.Threaded
{
    public class Calculator
    {
        struct ObjData
        {
            public GameObject gameObject;
            public Vector3 position;
            
            public ObjData(GameObject _gameObject, Vector3 _position)
            {
                gameObejct = _gameObject;
                position = _position;
            }
        }
        
        public GameObject FindClosestObject(List<GameObject> objs, Transform baseObject)
        {
            float shortestDistance = float.infinity;
            GameObject closestObject;
            //Iterate through all gameObjects, assigning to a Vector3[] variable
            ConcurrentQueue<ObjData> objDataQueue = new ConcurrentQueue<ObjData>();
            foreach(GameObject obj in objs)
            {
                objDataQueue.Enqueue(new ObjData(obj, obj.transform.position));
            }
            
            //Start thread here
        }
    }
}
