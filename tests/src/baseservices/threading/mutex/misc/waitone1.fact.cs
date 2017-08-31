using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_misc_waitone1_waitone1_
    {
        [OuterLoop]
        [Fact]
        public void _mutex_misc_waitone1_waitone1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\misc\\waitone1\\waitone1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
