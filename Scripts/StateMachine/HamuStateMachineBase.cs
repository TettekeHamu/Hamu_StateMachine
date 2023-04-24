using System;

namespace TettekeKobo.StateMachine
{
    /// <summary>
    /// StateMachineの親クラス
    /// </summary>
    /// <typeparam name="T">変更したいIStateに対応するEnum</typeparam>
    public abstract class HamuStateMachineBase<T> : ITransitionState<T> where T : Enum
    {
        /// <summary>
        /// 現在のState
        /// </summary>
        private IState currentState;

        /// <summary>
        /// EnumをIStateに変更する処理(abstractなメソッド)
        /// </summary>
        /// <param name="stateType">Enumを受け取る</param>
        /// <returns>Stateを返す</returns>
        protected abstract IState ConvertToState(T stateType);
        
        /// <summary>
        /// Stateを変更する処理,外部から操作されないように明示的実装
        /// </summary>
        /// <param name="stateType">変更したいStateを表すEnum</param>
        void ITransitionState<T>.TransitionState(T stateType)
        {
            currentState.Exit();
            var newState = ConvertToState(stateType);
            currentState = newState;
            currentState.Enter();
        }

        /// <summary>
        /// 初期化用の処理
        /// </summary>
        /// <param name="stateType">最初に設定したいStateのType</param>
        public void Initialize(T stateType)
        {
            var startState = ConvertToState(stateType);
            currentState = startState;
            currentState.Enter();
        }

        /// <summary>
        /// 毎フレーム実行する処理
        /// </summary>
        public void MyUpdate()
        {
            currentState.MyUpdate();
        }

        /// <summary>
        /// 等間隔で実行する処理
        /// </summary>
        public void MyFixedUpdate()
        {
            currentState.MyFixedUpdate();
        }
    }
}
