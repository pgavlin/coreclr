using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_144257_vsw144257_vsw144257_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_144257_vsw144257_vsw144257_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\144257\\vsw144257\\vsw144257.cmd");
        }
    }
}
