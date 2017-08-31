using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _semaphore_ctoropen_semaphorectorneg3_semaphorectorneg3_
    {
        [OuterLoop]
        [Fact]
        public void _semaphore_ctoropen_semaphorectorneg3_semaphorectorneg3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\ctoropen\\semaphorectorneg3\\semaphorectorneg3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
