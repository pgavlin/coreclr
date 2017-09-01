using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _FPtrunc_convr8a_cs_r_convr8a_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _FPtrunc_convr8a_cs_r_convr8a_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\FPtrunc\\convr8a_cs_r\\convr8a_cs_r.cmd");
        }
    }
}
