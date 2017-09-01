using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0138_pow3_pow3_
    {
        [OuterLoop]
        [Fact]
        public void _0138_pow3_pow3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0138\\pow3\\pow3.cmd");
        }
    }
}
