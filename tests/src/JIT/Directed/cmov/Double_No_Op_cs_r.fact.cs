using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Double_No_Op_cs_r_Double_No_Op_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Double_No_Op_cs_r_Double_No_Op_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Double_No_Op_cs_r\\Double_No_Op_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
