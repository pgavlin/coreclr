using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0583_Test583_Test583_
    {
        [OuterLoop]
        [Fact]
        public void _0583_Test583_Test583_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0583\\Test583\\Test583.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
