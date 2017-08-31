using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _semaphore_ctoropen_semaphorector1_semaphorector1_
    {
        [OuterLoop]
        [Fact]
        public void _semaphore_ctoropen_semaphorector1_semaphorector1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\ctoropen\\semaphorector1\\semaphorector1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
