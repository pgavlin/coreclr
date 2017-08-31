using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _date_date_
    {
        [Fact]
        public void _date_date_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\date\\date.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
