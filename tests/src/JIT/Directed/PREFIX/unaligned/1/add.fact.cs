using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_unaligned_1_add_add_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_1_add_add_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\1\\add\\add.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
