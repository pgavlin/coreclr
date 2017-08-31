using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _GitHub_12224_Test12224_Test12224_
    {
        [OuterLoop]
        [Fact]
        public void _GitHub_12224_Test12224_Test12224_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\GitHub_12224\\Test12224\\Test12224.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
