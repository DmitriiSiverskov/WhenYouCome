using Enum.Player;
using Interface;
using UnityEngine;
using Action = Interface.Action;

namespace AbstractClass
{
    public class CharacterBase : MonoBehaviour
    {
        [SerializeField] public StateCharacterEnum stateCharacterEnum;
        [SerializeField] protected GameObject _leftLeg;
        [SerializeField] protected GameObject _rightLeg;

        [SerializeField] protected Transform _transformPlayer;
        [SerializeField] protected Animator _animator;

        [SerializeField] protected AudioClip[] _audioClips;
        [SerializeField] protected AudioSource _audioSource;
        
        [SerializeField] protected float _speedRotation;
        [SerializeField] protected  float _speedMove;

        protected Move _moveBehaviour;
        protected Action _actionBehaviour;
        protected State _stateBehaviour;
        protected SoundWhenWalking _soundWhenWalkingBehaviour;

        protected void SetMove(Move move)
        {
            _moveBehaviour = move;
        }

        protected void SetAction(Action action)
        {
            _actionBehaviour = action;
        }

        protected void SetState(State state)
        {
            _stateBehaviour = state;
        }

        protected void SetSoundWhenWalking(SoundWhenWalking soundWhenWalking)
        {
            _soundWhenWalkingBehaviour = soundWhenWalking;
        }
        
        //=========================================================================================================
        protected void Move()
        {
            _moveBehaviour.Move();
        }

        protected void Action()
        {
            _actionBehaviour.Action();
        }

        protected void State()
        {
            _stateBehaviour.ConditionState();
        }

        protected void SoundWhenWalking(string foor)
        {
            _soundWhenWalkingBehaviour.SoundWhenWalking(foor);
        }
        
    }
}