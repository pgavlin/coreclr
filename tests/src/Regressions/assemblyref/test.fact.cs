using CoreclrTestLib;
using Xunit;

namespace Regressions_assemblyref
{
    class _test_test_
    {
        [OuterLoop]
        [Fact]
        public void _test_test_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\assemblyref\\test\\test.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
