using System.Collections;
using System.Collections.Generic;

namespace Asteroids.Models
{
    internal interface IAbilityEnumerator
    {
        Ability this[int index] { get; }

        IEnumerator GetEnumerator();
        IEnumerable<Ability> GetAbility(AbilityType index);
        IEnumerable<Ability> GetAbility(AbilityName index);
        public void AddAbility(Ability ability);
    }
}
