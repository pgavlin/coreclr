using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_abandonedmutex_am06abandonall_am06abandonall_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_abandonedmutex_am06abandonall_am06abandonall_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\abandonedmutex\\am06abandonall\\am06abandonall.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
