using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_box_unbox_box_unbox_box_unbox023_box_unbox023_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_box_unbox_box_unbox023_box_unbox023_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\box-unbox\\box-unbox023\\box-unbox023.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
