using UnityEngine;

namespace TettekeKobo.StateMachine.Sample
{
    /// <summary>
    /// GameObject（UIManager）にアタッチするクラス
    /// </summary>
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private UIChangeController uiChangeController;
        
        private UIStateMachine uiStateMachine;

        private void Awake()
        {
            uiStateMachine = new UIStateMachine(uiChangeController);
        }

        private void Start()
        {
            uiStateMachine.Initialize(UIStateType.OpeningNone);
        }

        private void Update()
        {
            uiStateMachine.MyUpdate();
        }

        private void FixedUpdate()
        {
            uiStateMachine.MyFixedUpdate();
        }
    }
}
