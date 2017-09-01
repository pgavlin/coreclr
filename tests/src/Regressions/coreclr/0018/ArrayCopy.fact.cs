using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0018_ArrayCopy_ArrayCopy_
    {
        [OuterLoop]
        [Fact]
        public void _0018_ArrayCopy_ArrayCopy_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0018\\ArrayCopy\\ArrayCopy.cmd");
        }
    }
}
