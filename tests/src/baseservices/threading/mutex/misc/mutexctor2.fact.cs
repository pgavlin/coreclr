using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_misc_mutexctor2_mutexctor2_
    {
        [OuterLoop]
        [Fact]
        public void _mutex_misc_mutexctor2_mutexctor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\misc\\mutexctor2\\mutexctor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
