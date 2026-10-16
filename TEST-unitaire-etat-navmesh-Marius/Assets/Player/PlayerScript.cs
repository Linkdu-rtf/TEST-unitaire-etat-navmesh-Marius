using System.Runtime.CompilerServices;
using UnityEngine;
namespace TEST.Player
{
    public StateMachine machine;
    public class PlayerScript
    {


        public PlayerScript()
        {
            machine.AddTransition
            
            Idle = new IdleState(this); 
            Run = new RunState(this);

        }

        public IdleState Idle { get; set; }
        public RunState Run { get; set; }
    }
}
