using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StrAccess_straccess2_cs_r_straccess2_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _StrAccess_straccess2_cs_r_straccess2_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StrAccess\\straccess2_cs_r\\straccess2_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
