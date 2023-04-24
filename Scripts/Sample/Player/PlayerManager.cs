using UnityEngine;

namespace TettekeKobo.StateMachine.Sample
{
    /// <summary>
    /// GameObject（Player）にアタッチするクラス
    /// </summary>
    public class PlayerManager : MonoBehaviour
    {
        private readonly PlayerStateMachine playerStateMachine = new PlayerStateMachine();

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
