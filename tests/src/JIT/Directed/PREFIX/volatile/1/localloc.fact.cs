using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_volatile_1_localloc_localloc_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_volatile_1_localloc_localloc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\volatile\\1\\localloc\\localloc.cmd");
        }
    }
}
