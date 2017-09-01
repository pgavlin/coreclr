using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _monitor_unownedlock_EnterExitExit_EnterExitExit_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_unownedlock_EnterExitExit_EnterExitExit_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\unownedlock\\EnterExitExit\\EnterExitExit.cmd");
        }
    }
}
