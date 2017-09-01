using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_r8NaNdiv_cs_d_r8NaNdiv_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r8NaNdiv_cs_d_r8NaNdiv_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r8NaNdiv_cs_d\\r8NaNdiv_cs_d.cmd");
        }
    }
}
