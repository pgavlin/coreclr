using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _refany_lcs_lcs_
    {
        [OuterLoop]
        [Fact]
        public void _refany_lcs_lcs_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\lcs\\lcs.cmd");
        }
    }
}
