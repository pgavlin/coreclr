using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_simple_precise2_cs_do_precise2_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_precise2_cs_do_precise2_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\precise2_cs_do\\precise2_cs_do.cmd");
        }
    }
}
