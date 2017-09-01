using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_rem_u8rem_cs_d_u8rem_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_rem_u8rem_cs_d_u8rem_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\rem\\u8rem_cs_d\\u8rem_cs_d.cmd");
        }
    }
}
