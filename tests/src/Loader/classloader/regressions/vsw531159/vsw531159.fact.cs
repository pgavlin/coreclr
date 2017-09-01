using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_vsw531159_vsw531159_vsw531159_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_vsw531159_vsw531159_vsw531159_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\vsw531159\\vsw531159\\vsw531159.cmd");
        }
    }
}
