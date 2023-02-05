using AbstractClass;
using Behaviour.Player;
using Enum.Player;
using UnityEngine;
using Event = GlobalEvent.Player.Event;

namespace PlayerClass
{
    public class Player : CharacterBase
    {
        [SerializeField] protected FixedJoystick _fixedJoystick;
        
        private void Awake()
        {
            _leftLeg.AddComponent<LeftStep>();
            _rightLeg.AddComponent<RightStep>();
            
            SetMove(new PlayerBehaviour(_fixedJoystick,_transformPlayer,_speedMove,_speedRotation));
            SetState(new StatePlayerBehaviour(_fixedJoystick));
            SetAction(new ActionPlayerBehaviour(_animator,this));
            SetSoundWhenWalking(new SoundWhenWalkingBehaviour(_audioClips,_audioSource,this));
            
            Event.Step.AddListener(SoundWhenWalking);
            Event.SetStateCharacter.AddListener(SetStatePlayer);
        }
        
        private void Update()
        {
            Move();
            State();
            Action();
        }

        private void SetStatePlayer(StateCharacterEnum stateCharacterEnum)
        {
            this.stateCharacterEnum = stateCharacterEnum;
        }
    }
}