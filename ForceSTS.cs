using Exiled.API.Features;
namespace ForceSTS
{
    public class ForceSTS : Plugin<Config>
    {
        public override string Name { get; } = "ForceSTS";
        public override string Author { get; } = "JesusQC with <3";
        public override string Prefix { get; } = "ForceSTS";
        public EventHandlers EventHandlers;
        public override void OnEnabled()
        {
            EventHandlers = new EventHandlers(this);
            base.OnEnabled();
            Exiled.Events.Handlers.Server.RespawningTeam += EventHandlers.OnRespawningTeamNTF;
        }
        public override void OnDisabled()
        {
            base.OnDisabled();
            EventHandlers = null;
            Exiled.Events.Handlers.Server.RespawningTeam -= EventHandlers.OnRespawningTeamNTF;
        }
    }
}