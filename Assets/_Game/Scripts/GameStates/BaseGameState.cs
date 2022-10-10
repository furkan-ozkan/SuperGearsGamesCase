namespace _Game.Scripts.GameStates
{
    public abstract class BaseGameState
    {
        public abstract void EnterState();
        public abstract void UpdateState();
        public abstract void ExitState();
    }
}
