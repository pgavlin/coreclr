using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0308_ToLower_ToLower_
    {
        [OuterLoop]
        [Fact]
        public void _0308_ToLower_ToLower_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0308\\ToLower\\ToLower.cmd");
        }
    }
}
