using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_box_unbox_value_box_unbox_value045_box_unbox_value045_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_value_box_unbox_value045_box_unbox_value045_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\value\\box-unbox-value045\\box-unbox-value045.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
