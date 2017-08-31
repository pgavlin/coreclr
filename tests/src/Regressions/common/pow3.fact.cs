using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _pow3_pow3_
    {
        [Fact]
        public void _pow3_pow3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\pow3\\pow3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
