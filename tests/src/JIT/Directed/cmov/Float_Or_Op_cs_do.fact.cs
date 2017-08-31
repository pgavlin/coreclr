using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _cmov_Float_Or_Op_cs_do_Float_Or_Op_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cmov_Float_Or_Op_cs_do_Float_Or_Op_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\cmov\\Float_Or_Op_cs_do\\Float_Or_Op_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
