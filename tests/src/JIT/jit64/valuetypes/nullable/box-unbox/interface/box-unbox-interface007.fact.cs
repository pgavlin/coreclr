using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_box_unbox_interface_box_unbox_interface007_box_unbox_interface007_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_interface_box_unbox_interface007_box_unbox_interface007_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\interface\\box-unbox-interface007\\box-unbox-interface007.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
