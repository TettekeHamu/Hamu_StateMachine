using TettekeKobo.StateMachine;
using UnityEngine;

namespace TettekeKobo.StatePatternTest
{
    /// <summary>
    /// ジャンプ中のState
    /// </summary>
    public class JumpState : IState
    {
        private readonly ITransitionState<PlayerStateType> transitionState;

        private float jumpTime;

        public JumpState(ITransitionState<PlayerStateType> transitionState)
        {
            this.transitionState = transitionState;
        }
        
        public void Enter()
        {
            Debug.Log("ジャンプ開始");
            jumpTime = 0;
        }

        public void MyUpdate()
        {
            //一定時間したらIdleStateに遷移
            jumpTime += Time.deltaTime;
            if(jumpTime >= 1) transitionState.TransitionState(PlayerStateType.Idle);
        }

        public void MyFixedUpdate()
        {
            
        }

        public void Exit()
        {
            
        }
    }
}
