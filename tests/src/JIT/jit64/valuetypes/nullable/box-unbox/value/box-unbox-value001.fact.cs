using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_box_unbox_value_box_unbox_value001_box_unbox_value001_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_value_box_unbox_value001_box_unbox_value001_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\value\\box-unbox-value001\\box-unbox-value001.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
