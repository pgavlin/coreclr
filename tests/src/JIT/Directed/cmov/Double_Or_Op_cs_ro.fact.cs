using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Double_Or_Op_cs_ro_Double_Or_Op_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Double_Or_Op_cs_ro_Double_Or_Op_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Double_Or_Op_cs_ro\\Double_Or_Op_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
