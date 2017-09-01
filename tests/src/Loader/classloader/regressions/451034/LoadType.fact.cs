using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_451034_LoadType_LoadType_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_451034_LoadType_LoadType_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\451034\\LoadType\\LoadType.cmd");
        }
    }
}
