using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_237932_repro237932_repro237932_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_237932_repro237932_repro237932_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\237932\\repro237932\\repro237932.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
