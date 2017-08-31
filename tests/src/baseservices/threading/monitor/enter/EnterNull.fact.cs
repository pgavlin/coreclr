using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _monitor_enter_EnterNull_EnterNull_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_enter_EnterNull_EnterNull_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\enter\\EnterNull\\EnterNull.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
