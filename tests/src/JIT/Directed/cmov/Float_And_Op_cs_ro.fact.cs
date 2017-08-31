using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Float_And_Op_cs_ro_Float_And_Op_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Float_And_Op_cs_ro_Float_And_Op_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Float_And_Op_cs_ro\\Float_And_Op_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
