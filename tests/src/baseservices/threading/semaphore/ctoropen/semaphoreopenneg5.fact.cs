using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _semaphore_ctoropen_semaphoreopenneg5_semaphoreopenneg5_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _semaphore_ctoropen_semaphoreopenneg5_semaphoreopenneg5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\ctoropen\\semaphoreopenneg5\\semaphoreopenneg5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
