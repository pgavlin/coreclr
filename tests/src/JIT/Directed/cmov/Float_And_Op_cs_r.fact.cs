using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Float_And_Op_cs_r_Float_And_Op_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Float_And_Op_cs_r_Float_And_Op_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Float_And_Op_cs_r\\Float_And_Op_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
