using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_r4NaNadd_cs_r_r4NaNadd_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r4NaNadd_cs_r_r4NaNadd_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r4NaNadd_cs_r\\r4NaNadd_cs_r.cmd");
        }
    }
}
