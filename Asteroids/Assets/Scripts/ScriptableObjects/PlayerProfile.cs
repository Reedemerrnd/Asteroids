using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Profiles
{
    [CreateAssetMenu(menuName ="Profiles")]
    public class PlayerProfile : ScriptableObject
    {
        public string Name;
        public int TotalScore;
        public int LevelsPassed;
        public int LevelesFailed;
    }
}
