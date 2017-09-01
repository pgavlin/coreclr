using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_u4rem_cs_d_u4rem_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_u4rem_cs_d_u4rem_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\u4rem_cs_d\\u4rem_cs_d.cmd");
        }
    }
}
