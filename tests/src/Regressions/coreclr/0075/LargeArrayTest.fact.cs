using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0075_LargeArrayTest_LargeArrayTest_
    {
        [OuterLoop]
        [Fact]
        public void _0075_LargeArrayTest_LargeArrayTest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0075\\LargeArrayTest\\LargeArrayTest.cmd");
        }
    }
}
