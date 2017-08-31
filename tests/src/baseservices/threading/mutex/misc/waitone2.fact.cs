using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_misc_waitone2_waitone2_
    {
        [OuterLoop]
        [Fact]
        public void _mutex_misc_waitone2_waitone2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\misc\\waitone2\\waitone2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
