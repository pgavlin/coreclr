using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_box_unbox_null_box_unbox_null042_box_unbox_null042_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_null_box_unbox_null042_box_unbox_null042_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\null\\box-unbox-null042\\box-unbox-null042.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
