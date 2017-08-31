using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _test1307_test1307_
    {
        [OuterLoop]
        [Fact]
        public void _test1307_test1307_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\test1307\\test1307.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
