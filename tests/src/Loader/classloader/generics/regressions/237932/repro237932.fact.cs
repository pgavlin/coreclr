using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _generics_regressions_237932_repro237932_repro237932_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_237932_repro237932_repro237932_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\237932\\repro237932\\repro237932.cmd");
        }
    }
}
