using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Int_Or_Op_cs_r_Int_Or_Op_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Int_Or_Op_cs_r_Int_Or_Op_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Int_Or_Op_cs_r\\Int_Or_Op_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
