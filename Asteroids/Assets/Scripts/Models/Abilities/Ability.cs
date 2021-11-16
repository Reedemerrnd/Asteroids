using UnityEngine;

namespace Asteroids.Models
{
    [CreateAssetMenu(menuName = "Abilities")]
    public class Ability : ScriptableObject
    {
        public AbilityType Type;
        public AbilityName Name;
        public float Value;
    }
}
