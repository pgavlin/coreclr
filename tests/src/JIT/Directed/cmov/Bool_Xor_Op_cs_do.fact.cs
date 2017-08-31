using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Bool_Xor_Op_cs_do_Bool_Xor_Op_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Bool_Xor_Op_cs_do_Bool_Xor_Op_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Bool_Xor_Op_cs_do\\Bool_Xor_Op_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
