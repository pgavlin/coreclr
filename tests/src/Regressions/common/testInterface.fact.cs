using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _testInterface_testInterface_
    {
        [OuterLoop]
        [Fact]
        public void _testInterface_testInterface_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\testInterface\\testInterface.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
