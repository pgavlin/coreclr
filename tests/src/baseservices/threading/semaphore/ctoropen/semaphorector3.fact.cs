using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _semaphore_ctoropen_semaphorector3_semaphorector3_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _semaphore_ctoropen_semaphorector3_semaphorector3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\ctoropen\\semaphorector3\\semaphorector3.cmd");
        }
    }
}
