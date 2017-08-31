using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_abandonedmutex_am08mixedarray_am08mixedarray_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_abandonedmutex_am08mixedarray_am08mixedarray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\abandonedmutex\\am08mixedarray\\am08mixedarray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
