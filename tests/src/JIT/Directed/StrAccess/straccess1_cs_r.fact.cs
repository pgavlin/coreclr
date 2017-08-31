using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StrAccess_straccess1_cs_r_straccess1_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _StrAccess_straccess1_cs_r_straccess1_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StrAccess\\straccess1_cs_r\\straccess1_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
