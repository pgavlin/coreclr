using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_r8NaNadd_cs_ro_r8NaNadd_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r8NaNadd_cs_ro_r8NaNadd_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r8NaNadd_cs_ro\\r8NaNadd_cs_ro.cmd");
        }
    }
}
