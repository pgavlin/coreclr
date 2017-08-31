using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _semaphore_ctoropen_semaphorectorneg2_semaphorectorneg2_
    {
        [OuterLoop]
        [Fact]
        public void _semaphore_ctoropen_semaphorectorneg2_semaphorectorneg2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\ctoropen\\semaphorectorneg2\\semaphorectorneg2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
