using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_r8NaNrem_cs_r_r8NaNrem_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r8NaNrem_cs_r_r8NaNrem_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r8NaNrem_cs_r\\r8NaNrem_cs_r.cmd");
        }
    }
}
