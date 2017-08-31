using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _ConstrainedCall_class1_cs_do_class1_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _ConstrainedCall_class1_cs_do_class1_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\ConstrainedCall\\class1_cs_do\\class1_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
