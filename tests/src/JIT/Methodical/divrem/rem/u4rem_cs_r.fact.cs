using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_u4rem_cs_r_u4rem_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_u4rem_cs_r_u4rem_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\u4rem_cs_r\\u4rem_cs_r.cmd");
        }
    }
}
