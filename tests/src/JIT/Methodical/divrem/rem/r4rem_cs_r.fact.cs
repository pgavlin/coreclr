using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_r4rem_cs_r_r4rem_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_r4rem_cs_r_r4rem_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\r4rem_cs_r\\r4rem_cs_r.cmd");
        }
    }
}
