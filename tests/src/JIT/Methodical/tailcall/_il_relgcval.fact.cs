using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_relgcval__il_relgcval_
    {
        [Fact]
        public void _tailcall__il_relgcval__il_relgcval_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_relgcval\\_il_relgcval.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
