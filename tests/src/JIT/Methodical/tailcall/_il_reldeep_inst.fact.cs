using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_reldeep_inst__il_reldeep_inst_
    {
        [Fact]
        public void _tailcall__il_reldeep_inst__il_reldeep_inst_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_reldeep_inst\\_il_reldeep_inst.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
