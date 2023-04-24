using UnityEngine;

namespace TettekeKobo.StateMachine.Sample
{
    /// <summary>
    /// 青い画像を表示しているときのState
    /// </summary>
    public class OpenBlueImageState : IState
    {
        private readonly ITransitionState<UIStateType> transitionState;
        private readonly UIChangeController uiChangeController;
        
        public OpenBlueImageState(ITransitionState<UIStateType> transitionState,UIChangeController uiChangeController)
        {
            this.transitionState = transitionState;
            this.uiChangeController = uiChangeController;
        }
        
        public void Enter()
        {
            Debug.Log("青色の画像を表示します");
            uiChangeController.SetEnableBlueImage(true);
        }

        public void MyUpdate()
        {
            if(Input.GetKeyDown(KeyCode.X)) transitionState.TransitionState(UIStateType.OpeningNone);
            else if(Input.GetKeyDown(KeyCode.Z)) transitionState.TransitionState(UIStateType.OpeningRedImage);
        }

        public void MyFixedUpdate()
        {
            
        }

        public void Exit()
        {
            uiChangeController.SetEnableBlueImage(false);
        }
    }
}
