using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Bool_Xor_Op_cs_r_Bool_Xor_Op_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Bool_Xor_Op_cs_r_Bool_Xor_Op_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Bool_Xor_Op_cs_r\\Bool_Xor_Op_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
