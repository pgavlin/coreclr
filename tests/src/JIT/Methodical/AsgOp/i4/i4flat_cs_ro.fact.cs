using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _AsgOp_i4_i4flat_cs_ro_i4flat_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_i4_i4flat_cs_ro_i4flat_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\i4\\i4flat_cs_ro\\i4flat_cs_ro.cmd");
        }
    }
}
