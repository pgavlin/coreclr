using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_box_unbox_generics_box_unbox_generics006_box_unbox_generics006_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_generics_box_unbox_generics006_box_unbox_generics006_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\generics\\box-unbox-generics006\\box-unbox-generics006.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
