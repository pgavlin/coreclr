using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _monitor_wait_waitnull_waitnull_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_wait_waitnull_waitnull_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\wait\\waitnull\\waitnull.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
