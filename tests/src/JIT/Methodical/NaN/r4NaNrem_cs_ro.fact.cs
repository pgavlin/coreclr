using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_r4NaNrem_cs_ro_r4NaNrem_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r4NaNrem_cs_ro_r4NaNrem_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r4NaNrem_cs_ro\\r4NaNrem_cs_ro.cmd");
        }
    }
}
