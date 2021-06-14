namespace MemeShark.Core.Common
{
    interface IDriverController
    {
        public bool IsDriverPresent { get; }

        public void Run();
        public void Stop();
    }
}