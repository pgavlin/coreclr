using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_abandonedmutex_am05waitanymutex_am05waitanymutex_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_abandonedmutex_am05waitanymutex_am05waitanymutex_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\abandonedmutex\\am05waitanymutex\\am05waitanymutex.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
