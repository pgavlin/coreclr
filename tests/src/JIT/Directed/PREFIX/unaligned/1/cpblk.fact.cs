using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_unaligned_1_cpblk_cpblk_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_1_cpblk_cpblk_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\1\\cpblk\\cpblk.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
