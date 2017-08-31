using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_regressions_dev10_393447_dev10_393447_dev10_393447_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_dev10_393447_dev10_393447_dev10_393447_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\dev10_393447\\dev10_393447\\dev10_393447.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
