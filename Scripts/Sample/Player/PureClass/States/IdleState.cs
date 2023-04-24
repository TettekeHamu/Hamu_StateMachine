using TettekeKobo.StateMachine;
using UnityEngine;

namespace TettekeKobo.StatePatternTest
{
    /// <summary>
    /// プレイヤーが待機中のState
    /// </summary>
    public class IdleState : IState
    {
        private readonly ITransitionState<PlayerStateType> transitionState;

        public IdleState(ITransitionState<PlayerStateType> transitionState)
        {
            this.transitionState = transitionState;
        }
        
        public void Enter()
        {
            Debug.Log("止まりました");
        }

        public void MyUpdate()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                //Wキーでジャンプ
                transitionState.TransitionState(PlayerStateType.Jump);
            }
            else if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                //Aキー or Dキーで歩く
                transitionState.TransitionState(PlayerStateType.Walk);
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
