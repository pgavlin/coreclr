using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_abandonedmutex_am05waitanymutex_am05waitanymutex_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_abandonedmutex_am05waitanymutex_am05waitanymutex_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\abandonedmutex\\am05waitanymutex\\am05waitanymutex.cmd");
        }
    }
}
