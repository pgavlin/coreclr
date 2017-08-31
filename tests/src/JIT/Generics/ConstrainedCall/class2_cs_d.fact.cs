using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _ConstrainedCall_class2_cs_d_class2_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _ConstrainedCall_class2_cs_d_class2_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\ConstrainedCall\\class2_cs_d\\class2_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
