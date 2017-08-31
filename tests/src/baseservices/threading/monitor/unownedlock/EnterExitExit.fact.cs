using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _monitor_unownedlock_EnterExitExit_EnterExitExit_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_unownedlock_EnterExitExit_EnterExitExit_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\unownedlock\\EnterExitExit\\EnterExitExit.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
