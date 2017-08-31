using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _Misc_SIDEEFFECTS_BadRegArgs_BadRegArgs_
    {
        [OuterLoop]
        [Fact]
        public void _Misc_SIDEEFFECTS_BadRegArgs_BadRegArgs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\Misc\\SIDEEFFECTS\\BadRegArgs\\BadRegArgs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
