using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_box_unbox_generics_box_unbox_generics002_box_unbox_generics002_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_box_unbox_generics_box_unbox_generics002_box_unbox_generics002_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\box-unbox\\generics\\box-unbox-generics002\\box-unbox-generics002.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
