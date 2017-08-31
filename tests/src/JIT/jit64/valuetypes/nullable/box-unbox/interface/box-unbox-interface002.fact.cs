using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_box_unbox_interface_box_unbox_interface002_box_unbox_interface002_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_interface_box_unbox_interface002_box_unbox_interface002_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\interface\\box-unbox-interface002\\box-unbox-interface002.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
