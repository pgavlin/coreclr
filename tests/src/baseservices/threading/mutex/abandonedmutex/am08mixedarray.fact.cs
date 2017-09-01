using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_abandonedmutex_am08mixedarray_am08mixedarray_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_abandonedmutex_am08mixedarray_am08mixedarray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\abandonedmutex\\am08mixedarray\\am08mixedarray.cmd");
        }
    }
}
