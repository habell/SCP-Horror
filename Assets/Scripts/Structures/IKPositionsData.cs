using System;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public struct IKPositionsData
    {
        public AvatarIKGoal BonePositionType;
        public Transform Position;
    }
}