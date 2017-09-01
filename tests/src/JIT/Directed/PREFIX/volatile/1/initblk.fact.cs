using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_volatile_1_initblk_initblk_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_volatile_1_initblk_initblk_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\volatile\\1\\initblk\\initblk.cmd");
        }
    }
}
