using UnityEngine;

namespace TettekeKobo.StatePatternTest
{
    /// <summary>
    /// GameObject（Player）にアタッチするクラス
    /// </summary>
    public class PlayerManager : MonoBehaviour
    {
        private PlayerStateMachine playerStateMachine;

        private void Awake()
        {
            playerStateMachine = new PlayerStateMachine();
        }

        private void Start()
        {
            playerStateMachine.Initialize(PlayerStateType.Idle);
        }

        private void Update()
        {
            playerStateMachine.MyUpdate();
        }

        private void FixedUpdate()
        {
            playerStateMachine.MyFixedUpdate();
        }
    }
}
