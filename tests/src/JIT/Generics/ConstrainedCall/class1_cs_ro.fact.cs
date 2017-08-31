using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _ConstrainedCall_class1_cs_ro_class1_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _ConstrainedCall_class1_cs_ro_class1_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\ConstrainedCall\\class1_cs_ro\\class1_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
