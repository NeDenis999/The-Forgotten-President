namespace Code.Services
{
    public class Services
    {
        public IInputService InputService;
        public ILogService LogService;
        public ITimeService TimeService;
        public IViewService ViewService;
        public IIdentifierService IdentifierService;
        public ICoroutineDirectorService CoroutineDirectorService;
        public IRegisterService<IViewController> CollidingViewRegister;
    }
}