using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0198_CompEx_CompEx_
    {
        [OuterLoop]
        [Fact]
        public void _0198_CompEx_CompEx_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0198\\CompEx\\CompEx.cmd");
        }
    }
}
