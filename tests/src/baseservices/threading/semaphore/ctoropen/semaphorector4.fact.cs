using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _semaphore_ctoropen_semaphorector4_semaphorector4_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _semaphore_ctoropen_semaphorector4_semaphorector4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\ctoropen\\semaphorector4\\semaphorector4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
