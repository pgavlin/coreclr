using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _semaphore_ctoropen_semaphorectorneg1_semaphorectorneg1_
    {
        [OuterLoop]
        [Fact]
        public void _semaphore_ctoropen_semaphorectorneg1_semaphorectorneg1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\ctoropen\\semaphorectorneg1\\semaphorectorneg1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
