using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_r8NaNmul_cs_r_r8NaNmul_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r8NaNmul_cs_r_r8NaNmul_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r8NaNmul_cs_r\\r8NaNmul_cs_r.cmd");
        }
    }
}
