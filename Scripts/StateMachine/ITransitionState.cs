using System;
namespace TettekeKobo.StateMachine
{
    /// <summary>
    /// Stateを変更する処理を持つInterface
    /// </summary>
    /// <typeparam name="T1">変更したいStateを表すEnum</typeparam>
    public interface ITransitionState<in T1> where T1 : Enum
    {
        /// <summary>
        /// Stateを変更する処理
        /// </summary>
        /// <param name="stateType">変更したいStateを表すEnum</param>
        public void TransitionState(T1 stateType);

        /// <summary>
        /// EnumをIStateに変更する処理
        /// </summary>
        /// <param name="stateType">Enumを受け取る</param>
        /// <returns>Stateを返す</returns>
        public IState ConvertToState(T1 stateType);
    }
}
