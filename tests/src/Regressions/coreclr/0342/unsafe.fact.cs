using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0342_unsafe_unsafe_
    {
        [OuterLoop]
        [Fact]
        public void _0342_unsafe_unsafe_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0342\\unsafe\\unsafe.cmd");
        }
    }
}
