using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _testClass_testClass_
    {
        [OuterLoop]
        [Fact]
        public void _testClass_testClass_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\testClass\\testClass.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
