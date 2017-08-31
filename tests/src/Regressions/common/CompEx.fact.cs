using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _CompEx_CompEx_
    {
        [Fact]
        public void _CompEx_CompEx_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\CompEx\\CompEx.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
