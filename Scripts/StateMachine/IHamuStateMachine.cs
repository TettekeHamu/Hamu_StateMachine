using System;

namespace TettekeKobo.StateMachine
{
    /// <summary>
    /// Stateを管理する処理をもつInterface(StateMachineクラスに実装)
    /// </summary>
    /// <typeparam name="T1">変更したいIStateに対応するEnum</typeparam>
    public interface IHamuStateMachine<in T1> where T1 : Enum
    {
        /// <summary>
        /// 初期化用の処理
        /// </summary>
        /// <param name="stateType">最初に設定したいStateのType</param>
        public void Initialize(T1 stateType);

        /// <summary>
        /// 毎フレーム実行する処理
        /// </summary>
        public void MyUpdate();

        /// <summary>
        /// 等間隔で実行する処理
        /// </summary>
        public void MyFixedUpdate();
    }
}
