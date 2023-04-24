using UnityEngine;

namespace TettekeKobo.StateMachine.Sample
{
    /// <summary>
    /// 何も表示していない時のState
    /// </summary>
    public class OpenNoneState : IState
    {
        private readonly ITransitionState<UIStateType> transitionState;
        private readonly UIChangeController uiChangeController;
        
        public OpenNoneState(ITransitionState<UIStateType> transitionState,UIChangeController uiChangeController)
        {
            this.transitionState = transitionState;
            this.uiChangeController = uiChangeController;
        }
        
        public void Enter()
        {
            Debug.Log("UIをすべて閉じました");
        }

        public void MyUpdate()
        {
            //入力があったらImageを表示
            if(Input.GetKeyDown(KeyCode.Z)) transitionState.TransitionState(UIStateType.OpeningRedImage);
            else if(Input.GetKeyDown(KeyCode.C)) transitionState.TransitionState(UIStateType.OpeningBlueImage);
        }

        public void MyFixedUpdate()
        {
            
        }

        public void Exit()
        {
            
        }
    }
}
