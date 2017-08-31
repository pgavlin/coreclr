using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_reldeep_gc__il_reldeep_gc_
    {
        [Fact]
        public void _tailcall__il_reldeep_gc__il_reldeep_gc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_reldeep_gc\\_il_reldeep_gc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
