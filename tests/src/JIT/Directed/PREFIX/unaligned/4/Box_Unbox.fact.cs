using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_unaligned_4_Box_Unbox_Box_Unbox_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_4_Box_Unbox_Box_Unbox_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\4\\Box_Unbox\\Box_Unbox.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
