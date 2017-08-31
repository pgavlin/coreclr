using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StrAccess_straccess3_cs_d_straccess3_cs_d_
    {
        [Fact]
        public void _StrAccess_straccess3_cs_d_straccess3_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StrAccess\\straccess3_cs_d\\straccess3_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
