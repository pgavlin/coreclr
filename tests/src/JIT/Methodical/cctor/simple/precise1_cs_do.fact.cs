using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_simple_precise1_cs_do_precise1_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_simple_precise1_cs_do_precise1_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\simple\\precise1_cs_do\\precise1_cs_do.cmd");
        }
    }
}
