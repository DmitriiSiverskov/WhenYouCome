using Interface;
using UnityEngine;

namespace Behaviour.Player
{
    public class PlayerBehaviour : Move
    {
        private readonly FixedJoystick _fixedJoystick;
        private readonly Transform _transformPlayer;
        private readonly float _speedMove;
        private readonly float _speedRotation;

        public PlayerBehaviour(FixedJoystick fixedJoystick, Transform transformPlayer, float speedMove, float speedRotation)
        {
            _fixedJoystick = fixedJoystick;
            _transformPlayer = transformPlayer;
            _speedMove = speedMove;
            _speedRotation = speedRotation;
        }

        public void Move()
        {
            if (_fixedJoystick.Vertical != 0)
            {
                var fixedJoystickVertical = _fixedJoystick.Vertical * _speedMove * Time.deltaTime;
                var fixedJoystickHorizontal = _fixedJoystick.Horizontal * _speedRotation * Time.deltaTime;
                _transformPlayer.Translate(0,0,fixedJoystickVertical);
                _transformPlayer.Rotate(0,fixedJoystickHorizontal,0);
            }
        }
    }
}