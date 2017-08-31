using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_relgcval_sideeffect__il_relgcval_sideeffect_
    {
        [Fact]
        public void _tailcall__il_relgcval_sideeffect__il_relgcval_sideeffect_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_relgcval_sideeffect\\_il_relgcval_sideeffect.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
