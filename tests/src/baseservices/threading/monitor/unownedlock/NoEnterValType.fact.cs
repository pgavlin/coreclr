using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _monitor_unownedlock_NoEnterValType_NoEnterValType_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_unownedlock_NoEnterValType_NoEnterValType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\unownedlock\\NoEnterValType\\NoEnterValType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
