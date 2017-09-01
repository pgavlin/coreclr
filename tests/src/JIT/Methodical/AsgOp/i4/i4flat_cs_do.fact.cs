using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _AsgOp_i4_i4flat_cs_do_i4flat_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_i4_i4flat_cs_do_i4flat_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\i4\\i4flat_cs_do\\i4flat_cs_do.cmd");
        }
    }
}
