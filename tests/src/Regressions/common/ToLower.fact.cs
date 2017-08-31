using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _ToLower_ToLower_
    {
        [Fact]
        public void _ToLower_ToLower_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\ToLower\\ToLower.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
