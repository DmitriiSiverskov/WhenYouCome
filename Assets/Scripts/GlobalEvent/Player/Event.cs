using Enum.Player;
using UnityEngine;
using UnityEngine.Events;

namespace GlobalEvent.Player
{
    public class Event : MonoBehaviour
    {
        public static UnityEvent<StateCharacterEnum> SetStateCharacter = new UnityEvent<StateCharacterEnum>();
        public static UnityEvent<string> Step = new UnityEvent<string>();
    }
}