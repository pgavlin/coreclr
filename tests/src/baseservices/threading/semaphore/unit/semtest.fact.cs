using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _semaphore_unit_semtest_semtest_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _semaphore_unit_semtest_semtest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\unit\\semtest\\semtest.cmd");
        }
    }
}
