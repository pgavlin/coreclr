using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _ConstrainedCall_class2_il_r_class2_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _ConstrainedCall_class2_il_r_class2_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\ConstrainedCall\\class2_il_r\\class2_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
