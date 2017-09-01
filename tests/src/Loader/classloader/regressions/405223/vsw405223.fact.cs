using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_405223_vsw405223_vsw405223_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_405223_vsw405223_vsw405223_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\405223\\vsw405223\\vsw405223.cmd");
        }
    }
}
