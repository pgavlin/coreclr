using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_box_unbox_enum_box_unbox_enum003_box_unbox_enum003_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_enum_box_unbox_enum003_box_unbox_enum003_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\enum\\box-unbox-enum003\\box-unbox-enum003.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
