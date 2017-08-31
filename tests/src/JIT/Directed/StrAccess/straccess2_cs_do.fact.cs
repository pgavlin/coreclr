using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StrAccess_straccess2_cs_do_straccess2_cs_do_
    {
        [Fact]
        public void _StrAccess_straccess2_cs_do_straccess2_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StrAccess\\straccess2_cs_do\\straccess2_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
