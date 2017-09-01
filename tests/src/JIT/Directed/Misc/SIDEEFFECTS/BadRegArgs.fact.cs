using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _Misc_SIDEEFFECTS_BadRegArgs_BadRegArgs_
    {
        [OuterLoop]
        [Fact]
        public void _Misc_SIDEEFFECTS_BadRegArgs_BadRegArgs_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\Misc\\SIDEEFFECTS\\BadRegArgs\\BadRegArgs.cmd");
        }
    }
}
