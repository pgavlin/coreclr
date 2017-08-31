using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Bool_No_Op_cs_ro_Bool_No_Op_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Bool_No_Op_cs_ro_Bool_No_Op_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Bool_No_Op_cs_ro\\Bool_No_Op_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
