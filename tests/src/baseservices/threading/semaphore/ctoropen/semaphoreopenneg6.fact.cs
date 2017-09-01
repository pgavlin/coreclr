using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _semaphore_ctoropen_semaphoreopenneg6_semaphoreopenneg6_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _semaphore_ctoropen_semaphoreopenneg6_semaphoreopenneg6_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\ctoropen\\semaphoreopenneg6\\semaphoreopenneg6.cmd");
        }
    }
}
