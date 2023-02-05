using Enum.Player;
using Interface;
using UnityEngine;

namespace Behaviour.Player
{
    
    public class SoundWhenWalkingBehaviour : SoundWhenWalking
    {
        private readonly AudioClip[] _audioClip;
        private readonly AudioSource _audioSource;
        private readonly PlayerClass.Player _player;

        public SoundWhenWalkingBehaviour(AudioClip[] audio, AudioSource audioSource, PlayerClass.Player player)
        {
            _audioClip = audio;
            _audioSource = audioSource;
            _player = player;
        }
        public void SoundWhenWalking(string foor)
        {
            if (_player.stateCharacterEnum != StateCharacterEnum.Idle)
            {
                switch (foor)
                {
                    case "ConcreteFloor":
                        _audioSource.PlayOneShot(_audioClip[0]);   
                        break;
                }
                   
            }
        }
        
    }
}