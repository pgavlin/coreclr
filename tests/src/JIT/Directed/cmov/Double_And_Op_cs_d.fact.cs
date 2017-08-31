using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Double_And_Op_cs_d_Double_And_Op_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Double_And_Op_cs_d_Double_And_Op_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Double_And_Op_cs_d\\Double_And_Op_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
