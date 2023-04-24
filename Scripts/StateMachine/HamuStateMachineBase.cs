using System;

namespace TettekeKobo.StateMachine
{
    /// <summary>
    /// StateMachineの親クラス
    /// </summary>
    /// <typeparam name="T1">変更したいIStateに対応するEnum</typeparam>
    public abstract class HamuStateMachineBase<T1> : ITransitionState<T1> where T1 : Enum
    {
        /// <summary>
        /// 現在のState
        /// </summary>
        private IState currentStare;

        /// <summary>
        /// EnumをIStateに変更する処理(abstractなメソッド)
        /// </summary>
        /// <param name="stateType">Enumを受け取る</param>
        /// <returns>Stateを返す</returns>
        public abstract IState ConvertToState(T1 stateType);
        
        /// <summary>
        /// Stateを変更する処理,外部から操作されないように明示的実装
        /// </summary>
        /// <param name="stateType">変更したいStateを表すEnum</param>
        void ITransitionState<T1>.TransitionState(T1 stateType)
        {
            currentStare.Exit();
            var newState = ConvertToState(stateType);
            currentStare = newState;
            currentStare.Enter();
        }

        /// <summary>
        /// 初期化用の処理
        /// </summary>
        /// <param name="stateType">最初に設定したいStateのType</param>
        public void Initialize(T1 stateType)
        {
            var startState = ConvertToState(stateType);
            currentStare = startState;
            currentStare.Enter();
        }

        /// <summary>
        /// 毎フレーム実行する処理
        /// </summary>
        public void MyUpdate()
        {
            currentStare.MyUpdate();
        }

        /// <summary>
        /// 等間隔で実行する処理
        /// </summary>
        public void MyFixedUpdate()
        {
            currentStare.MyFixedUpdate();
        }
    }
}
