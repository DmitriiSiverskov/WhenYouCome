using Enum.Player;
using GlobalEvent.Player;
using Interface;

namespace Behaviour.Player
{
    public class StatePlayerBehaviour : State
    {
        private readonly FixedJoystick _fixedJoystick;

        public StatePlayerBehaviour(FixedJoystick fixedJoystick)
        {
            _fixedJoystick = fixedJoystick;
        }
        public void ConditionState()
        {
            if (_fixedJoystick.Vertical == 0.0f)
            {
                SetStateCharacter(StateCharacterEnum.Idle);
            }
            else if (_fixedJoystick.Vertical > 0.0f)
            {
                SetStateCharacter(_fixedJoystick.Vertical > 0.5f ? StateCharacterEnum.Run : StateCharacterEnum.Move);
            }
            else if (_fixedJoystick.Vertical < 0.0f)
            {
                SetStateCharacter(StateCharacterEnum.Backward);
               
            }
        }

        private void SetStateCharacter(StateCharacterEnum stateCharacterEnum)
        {
            Event.SetStateCharacter.Invoke(stateCharacterEnum);
        }
    }
}