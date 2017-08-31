using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StrAccess_straccess1_cs_d_straccess1_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _StrAccess_straccess1_cs_d_straccess1_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StrAccess\\straccess1_cs_d\\straccess1_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
