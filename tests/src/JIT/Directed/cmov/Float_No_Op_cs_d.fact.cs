using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Float_No_Op_cs_d_Float_No_Op_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Float_No_Op_cs_d_Float_No_Op_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Float_No_Op_cs_d\\Float_No_Op_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
