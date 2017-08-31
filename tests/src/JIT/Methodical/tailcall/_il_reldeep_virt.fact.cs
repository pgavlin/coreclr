using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_reldeep_virt__il_reldeep_virt_
    {
        [Fact]
        public void _tailcall__il_reldeep_virt__il_reldeep_virt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_reldeep_virt\\_il_reldeep_virt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
