using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_r4NaNmul_cs_d_r4NaNmul_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r4NaNmul_cs_d_r4NaNmul_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r4NaNmul_cs_d\\r4NaNmul_cs_d.cmd");
        }
    }
}
