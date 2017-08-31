using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _1333_testClass_testClass_
    {
        [OuterLoop]
        [Fact]
        public void _1333_testClass_testClass_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\1333\\testClass\\testClass.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
