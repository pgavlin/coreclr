using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_generics_castclass_generics007_castclass_generics007_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_generics_castclass_generics007_castclass_generics007_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\generics\\castclass-generics007\\castclass-generics007.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
