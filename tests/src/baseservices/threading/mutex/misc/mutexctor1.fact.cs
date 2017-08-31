using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_misc_mutexctor1_mutexctor1_
    {
        [OuterLoop]
        [Fact]
        public void _mutex_misc_mutexctor1_mutexctor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\misc\\mutexctor1\\mutexctor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
