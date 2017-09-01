using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_abandonedmutex_am04waitany_am04waitany_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _mutex_abandonedmutex_am04waitany_am04waitany_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\abandonedmutex\\am04waitany\\am04waitany.cmd");
        }
    }
}
