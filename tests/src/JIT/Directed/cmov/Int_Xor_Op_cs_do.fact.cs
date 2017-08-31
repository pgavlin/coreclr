using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Int_Xor_Op_cs_do_Int_Xor_Op_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Int_Xor_Op_cs_do_Int_Xor_Op_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Int_Xor_Op_cs_do\\Int_Xor_Op_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
