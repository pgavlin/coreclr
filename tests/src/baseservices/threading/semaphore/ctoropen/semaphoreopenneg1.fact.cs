using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _semaphore_ctoropen_semaphoreopenneg1_semaphoreopenneg1_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _semaphore_ctoropen_semaphoreopenneg1_semaphoreopenneg1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\ctoropen\\semaphoreopenneg1\\semaphoreopenneg1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
