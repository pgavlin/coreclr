using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_unaligned_2_localloc_localloc_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_2_localloc_localloc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\2\\localloc\\localloc.cmd");
        }
    }
}
