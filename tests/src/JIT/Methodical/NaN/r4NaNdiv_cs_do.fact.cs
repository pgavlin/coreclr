using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _NaN_r4NaNdiv_cs_do_r4NaNdiv_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_r4NaNdiv_cs_do_r4NaNdiv_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\r4NaNdiv_cs_do\\r4NaNdiv_cs_do.cmd");
        }
    }
}
