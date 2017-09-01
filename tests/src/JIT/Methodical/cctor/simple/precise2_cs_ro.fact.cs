using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_simple_precise2_cs_ro_precise2_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_precise2_cs_ro_precise2_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\precise2_cs_ro\\precise2_cs_ro.cmd");
        }
    }
}
