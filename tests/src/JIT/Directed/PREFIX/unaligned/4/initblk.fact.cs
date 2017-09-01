using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_unaligned_4_initblk_initblk_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_4_initblk_initblk_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\4\\initblk\\initblk.cmd");
        }
    }
}
