using TettekeKobo.StateMachine;
using UnityEngine;

namespace TettekeKobo.StatePatternTest
{
    /// <summary>
    /// 移動中のState
    /// </summary>
    public class WalkState : IState
    {
        private readonly ITransitionState<PlayerStateType> transitionState;

        public WalkState(ITransitionState<PlayerStateType> transitionState)
        {
            this.transitionState = transitionState;
        }
        
        public void Enter()
        {
            Debug.Log("歩きます");
        }

        public void MyUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Wキーでジャンプ
                transitionState.TransitionState(PlayerStateType.Jump);
            }
            else if( !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) )
            {
                //速度が0なら止まる
                transitionState.TransitionState(PlayerStateType.Idle);
            }
        }

        public void MyFixedUpdate()
        {
            
        }

        public void Exit()
        {
            
        }
    }
}
