using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0275_Marshal_Marshal_
    {
        [OuterLoop]
        [Fact]
        public void _0275_Marshal_Marshal_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0275\\Marshal\\Marshal.cmd");
        }
    }
}
