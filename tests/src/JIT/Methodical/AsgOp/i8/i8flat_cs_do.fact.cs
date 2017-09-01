using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _AsgOp_i8_i8flat_cs_do_i8flat_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_i8_i8flat_cs_do_i8flat_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\i8\\i8flat_cs_do\\i8flat_cs_do.cmd");
        }
    }
}
