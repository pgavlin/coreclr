using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_unaligned_2_cpblk_cpblk_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_2_cpblk_cpblk_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\2\\cpblk\\cpblk.cmd");
        }
    }
}
