using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_r8NaNrem_cs_do_r8NaNrem_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r8NaNrem_cs_do_r8NaNrem_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r8NaNrem_cs_do\\r8NaNrem_cs_do.cmd");
        }
    }
}
