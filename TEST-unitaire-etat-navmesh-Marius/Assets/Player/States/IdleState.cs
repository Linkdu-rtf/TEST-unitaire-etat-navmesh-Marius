using UnityEditorInternal;

namespace TEST.Player
{
    // Walks to the assigned mine. The arrival is a transition condition declared in Worker.
    public sealed class IdleState : IState, IResumable
    {
        private readonly PlayerScript player; 

        public IdleState(PlayerScript player)
        {
            this.player = player;
        }

        public void Enter()
        {
            
        }

        public void Tick(float deltaTime)
        {
        }

        public void Exit()
        {
        }

        // The alert stopped the body on the way: the walk starts again from where it stands.
        public void Resume()
        {
        }
    }
}
