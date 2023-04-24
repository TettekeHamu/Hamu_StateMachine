using TettekeKobo.StateMachine;
using UnityEngine;

namespace TettekeKobo.StatePatternTest
{
    /// <summary>
    /// 青い画像を表示しているときのState
    /// </summary>
    public class OpenBlueImageState : IState
    {
        private readonly ITransitionState<UIStateType> transitionState;
        private UIChangeController uiChangeController;
        
        public OpenBlueImageState(ITransitionState<UIStateType> transitionState,UIChangeController uiChangeController)
        {
            this.transitionState = transitionState;
            this.uiChangeController = uiChangeController;
        }
        
        public void Enter()
        {
            Debug.Log("青色の画像を表示します");
            uiChangeController.ChangeBlueImage(true);
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
            uiChangeController.ChangeBlueImage(false);
        }
    }
}
