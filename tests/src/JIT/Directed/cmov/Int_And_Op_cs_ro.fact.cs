using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Int_And_Op_cs_ro_Int_And_Op_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Int_And_Op_cs_ro_Int_And_Op_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Int_And_Op_cs_ro\\Int_And_Op_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
