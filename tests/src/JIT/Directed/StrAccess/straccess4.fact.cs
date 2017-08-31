using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _StrAccess_straccess4_straccess4_
    {
        [Fact]
        public void _StrAccess_straccess4_straccess4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\StrAccess\\straccess4\\straccess4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
