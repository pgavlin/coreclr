using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Int_Or_Op_cs_ro_Int_Or_Op_cs_ro_
    {
        [Fact]
        public void _cmov_Int_Or_Op_cs_ro_Int_Or_Op_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Int_Or_Op_cs_ro\\Int_Or_Op_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
