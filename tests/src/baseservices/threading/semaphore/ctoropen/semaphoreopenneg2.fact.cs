using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _semaphore_ctoropen_semaphoreopenneg2_semaphoreopenneg2_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _semaphore_ctoropen_semaphoreopenneg2_semaphoreopenneg2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\ctoropen\\semaphoreopenneg2\\semaphoreopenneg2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
