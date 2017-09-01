using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_abandonedmutex_am07abandonmultiplemutex_am07abandonmultiplemutex_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_abandonedmutex_am07abandonmultiplemutex_am07abandonmultiplemutex_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\abandonedmutex\\am07abandonmultiplemutex\\am07abandonmultiplemutex.cmd");
        }
    }
}
