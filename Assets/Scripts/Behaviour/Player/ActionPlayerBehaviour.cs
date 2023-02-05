using Enum.Player;
using Interface;
using UnityEngine;

namespace Behaviour.Player
{
    public class ActionPlayerBehaviour : Action
    {
        private readonly Animator _animator;
        private readonly PlayerClass.Player _player;

        public ActionPlayerBehaviour(Animator animator, PlayerClass.Player player)
        {
            _animator = animator;
            _player = player;
        }
        public void Action()
        {
            switch (_player.stateCharacterEnum)
            {
                case StateCharacterEnum.Move: 
                    SetAnimator(true,false,false);
                    break;
                case StateCharacterEnum.Idle:
                    SetAnimator(false,false,false);
                    break;
                case StateCharacterEnum.Run: 
                    SetAnimator(false,true,false);
                    break;
                case StateCharacterEnum.Backward:
                    SetAnimator(true);
                        break;
            }
        }

        private void SetAnimator(bool isBackWard)
        {
            _animator.SetBool("IsBackWard", isBackWard);
        }

        private void SetAnimator(bool isRun, bool isBackWard)
        {
            _animator.SetBool("IsRun", isRun);
            SetAnimator(isBackWard);
        }
        private void SetAnimator(bool isMove,bool isRun,bool isBackWard)
        {
            _animator.SetBool("IsMove", isMove);
            SetAnimator(isRun,isBackWard);
        }
      
        
    }
}