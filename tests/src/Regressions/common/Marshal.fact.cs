using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _Marshal_Marshal_
    {
        [Fact]
        public void _Marshal_Marshal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\Marshal\\Marshal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
