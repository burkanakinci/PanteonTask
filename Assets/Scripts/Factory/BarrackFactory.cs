﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethod
{
    public class BarrackFactory : _BuildFactory<List<PathNode>>
    {
        public override GameObject build => Resources.Load<GameObject>("Prefabs/BarrackUtil");
        public override Transform buildParent => GameObject.FindGameObjectWithTag("BarrackParent").transform;
        public override void SpawnBuild(Vector3 spawnPos, List<PathNode> notWalkableNode)
        {
            for (int i = notWalkableNode.Count - 1; i >= 0; i--)
            {
                notWalkableNode[i].SetIsWalkable(false);
            }

            Transform.Instantiate(build, spawnPos, Quaternion.identity, buildParent);
        }
    }
}
