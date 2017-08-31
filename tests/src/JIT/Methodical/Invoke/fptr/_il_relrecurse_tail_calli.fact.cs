using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_fptr__il_relrecurse_tail_calli__il_relrecurse_tail_calli_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_fptr__il_relrecurse_tail_calli__il_relrecurse_tail_calli_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\fptr\\_il_relrecurse_tail_calli\\_il_relrecurse_tail_calli.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
