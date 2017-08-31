using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StrAccess_straccess1_cs_do_straccess1_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _StrAccess_straccess1_cs_do_straccess1_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StrAccess\\straccess1_cs_do\\straccess1_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
