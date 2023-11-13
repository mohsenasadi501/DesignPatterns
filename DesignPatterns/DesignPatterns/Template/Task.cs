namespace DesignPatterns.Template
{
    internal abstract class Task
    {
        private AuditTrail _auditTrail;

        public Task()
        {
            _auditTrail = new AuditTrail();
        }
        public Task(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }

        public void Execute()
        {
            _auditTrail.Record();
            doExecute();
        }
        protected abstract void doExecute();

        // These are "hooks." Subclasses may override them, but it's not
        // mandatory since the hooks already have default (but empty)
        // implementation. Hooks provide additional extension points in some
        // crucial places of the algorithm.
        protected virtual void Hook1() { }
        protected virtual void Hook2() { }
    }
}
