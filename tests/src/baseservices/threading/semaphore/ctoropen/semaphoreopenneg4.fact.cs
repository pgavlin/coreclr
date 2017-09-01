using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _semaphore_ctoropen_semaphoreopenneg4_semaphoreopenneg4_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _semaphore_ctoropen_semaphoreopenneg4_semaphoreopenneg4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\ctoropen\\semaphoreopenneg4\\semaphoreopenneg4.cmd");
        }
    }
}
