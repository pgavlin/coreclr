using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_abandonedmutex_am04waitany_am04waitany_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_abandonedmutex_am04waitany_am04waitany_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\abandonedmutex\\am04waitany\\am04waitany.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
