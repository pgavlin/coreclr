using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_r4NaNmul_cs_r_r4NaNmul_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r4NaNmul_cs_r_r4NaNmul_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r4NaNmul_cs_r\\r4NaNmul_cs_r.cmd");
        }
    }
}
