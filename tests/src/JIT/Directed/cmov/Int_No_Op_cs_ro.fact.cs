using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Int_No_Op_cs_ro_Int_No_Op_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Int_No_Op_cs_ro_Int_No_Op_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Int_No_Op_cs_ro\\Int_No_Op_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
