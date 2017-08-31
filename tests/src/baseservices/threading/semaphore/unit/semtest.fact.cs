using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _semaphore_unit_semtest_semtest_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _semaphore_unit_semtest_semtest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\unit\\semtest\\semtest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
