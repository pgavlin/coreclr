using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_generics_castclass_generics044_castclass_generics044_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_generics_castclass_generics044_castclass_generics044_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\generics\\castclass-generics044\\castclass-generics044.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
